using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChessInterface
{
    /// <summary>
    /// A user of the chess program.
    /// </summary>
    [Serializable]
    public class User
    {
        /// <summary>
        /// The user's name.
        /// </summary>
        public string Name;
        
        /// <summary>
        /// Whether moves should be announced.
        /// </summary>
        public bool AnnounceMoves;

        /// <summary>
        /// The location of the chess set for the player to use.
        /// </summary>
        public string ChessSetPath;

        /// <summary>
        /// The color of the light squares.
        /// </summary>
        public Color LightColor = Color.FromArgb(255, 206, 158);

        /// <summary>
        /// The color of the dark squares.
        /// </summary>
        public Color DarkColor = Color.FromArgb(209, 139, 71);

        #region Glicko2 Rating Variables/Procedures
        public const double SYSTEM_CONSTANT = 0.75;

        public double Rating, RatingDeviation, RatingVolatility;
        public Dictionary<DateTime, ChessMatch> Matches;
        public Dictionary<DateTime, double> RatingHistory;
        public DateTime LastUpdated;

        private static double Square(double x) { return x * x; }

        public static double ScaledMeasureOfDeviation(double rd)
        {
            return 1.0 / Math.Sqrt(1 + (3 * Square(rd)) / Square(Math.PI));
        }

        public static double ExpectedOutcome(double myRating, double opponentRating, double opponentRd)
        {
            return 1.0 / (1 + Math.Exp(-ScaledMeasureOfDeviation(opponentRd) * (myRating - opponentRating)));
        }

        public static double IllinoisFunction(double x, double delta, double phi, double v, double a)
        {
            return (Math.Exp(x) * (Square(delta) - Square(phi) - v - Math.Exp(x)) / (2 * Square((Square(phi) + v + Math.Exp(x))))) - ((x - a) / Square(SYSTEM_CONSTANT));
        }

        ///<summary>
        ///Returns all the days between the specified dates.
        ///</summary>
        ///<param name='from'>The date to start at.</param>
        ///<param name='to'>The date to end at.</param>
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime to)
        {
            for (DateTime day = from.Date; day.Date <= to.Date; day = day.AddDays(1))
                yield return day;
        }

        public IEnumerable<ChessMatch> MatchesOnSpecificDay(DateTime day)
        {
            return from match in Matches where match.Key.Date.Date == day.Date select match.Value;
        }

        public void UpdateRating()
        {
            foreach (DateTime day in EachDay(LastUpdated, DateTime.Now.Date))
            {
                double glicko2Rating = (Rating - 1500) / (400 / Math.Log(10));
                double glicko2RD = RatingDeviation / (400 / Math.Log(10));

                var matches = MatchesOnSpecificDay(day);

                if (matches.Count() > 0)
                {
                    // Calculate v and delta at the same time
                    double v = 0;
                    double delta = 0;

                    foreach (var match in matches)
                    {
                        double glicko2OpponentRating = (match.OpponentRating - 1500) / (400 / Math.Log(10));
                        double glicko2OpponentRD = match.OpponentDeviation / (400 / Math.Log(10));

                        double scaledDeviation = ScaledMeasureOfDeviation(glicko2OpponentRD);
                        double expected = ExpectedOutcome(glicko2Rating, glicko2OpponentRating, glicko2OpponentRD);

                        v += (Square(scaledDeviation) * expected * (1 - expected));
                        delta += scaledDeviation * (match.Outcome - expected);
                    }

                    v = 1.0 / v;
                    delta *= v;

                    double a = Math.Log(Square(RatingVolatility));
                    double epsilon = 0.000001;

                    double A = a;
                    double B = Math.Log(Square(delta) - Square(glicko2RD) - v);

                    if (Square(delta) <= Square(glicko2RD) + v)
                    {
                        double k = 1;
                        while (IllinoisFunction(a - k * SYSTEM_CONSTANT, delta, glicko2RD, v, a) < 0)
                        {
                            k++;
                        }
                        B = a - k * SYSTEM_CONSTANT;
                    }

                    double fA = IllinoisFunction(A, delta, glicko2RD, v, a);
                    double fB = IllinoisFunction(B, delta, glicko2RD, v, a);

                    while (Math.Abs(B - A) > epsilon)
                    {
                        double C = A + (A - B) * (fA / (fB - fA));
                        double fC = IllinoisFunction(C, delta, glicko2RD, v, a);

                        if (fC * fB < 0)
                        {
                            A = B;
                            fA = fB;
                        }
                        else
                        {
                            fA /= 2;
                        }

                        B = C;
                        fB = fC;
                    }

                    RatingVolatility = Math.Exp(A / 2);

                    double preRatingRD = Math.Sqrt(Square(glicko2RD) + Square(RatingVolatility));
                    glicko2RD = 1.0 / Math.Sqrt(1.0 / preRatingRD + 1.0 / v);
                    glicko2Rating += Square(glicko2RD) + (delta / v);
                }
                else
                {
                    // If no games occured, only step 6 applies
                    glicko2RD = Math.Sqrt(Square(glicko2RD) + Square(RatingVolatility));
                }

                Rating = (400 / Math.Log(10) * glicko2Rating) + 1500;
                RatingDeviation = (400 / Math.Log(10) * glicko2RD);
            }

            Matches = new Dictionary<DateTime, ChessMatch>();
            LastUpdated = DateTime.Now;
        }
        #endregion

        public User(string name, double rating = 1500, double rd = 350, double v = 0.06)
        {
            Name = name; Rating = rating; RatingDeviation = rd; RatingVolatility = v;
           // WhiteOutcomes = new int[3]; BlackOutcomes = new int[3];
            Matches = new Dictionary<DateTime, ChessMatch>();
            RatingHistory = new Dictionary<DateTime, double>();
            LastUpdated = DateTime.Now;
        }
    }
}
