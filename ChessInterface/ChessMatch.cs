using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessInterface
{
    [Serializable]
    public class ChessMatch
    {
        public double OpponentRating, OpponentDeviation;
        public double Outcome;

        public ChessMatch(double rating, double deviation, double outcome)
        {
            OpponentRating = rating; OpponentDeviation = deviation; Outcome = outcome;
        }
    }
}
