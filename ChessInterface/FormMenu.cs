using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using Newtonsoft.Json;

namespace ChessInterface
{
    public partial class FormMainMenu : Form
    {
        User currentUser;

        public FormMainMenu()
        {
            InitializeComponent();

            // See if there is a user file present
            if (File.Exists("user.json"))
            {
                currentUser = JsonConvert.DeserializeObject<User>(File.ReadAllText("user.json"));
            }
            else
            {
                string name;
                do
                {
                    name = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:");
                }
                while (string.IsNullOrWhiteSpace(name));
                
                currentUser = new User(name);
                File.WriteAllText("user.json", JsonConvert.SerializeObject(currentUser));
            }

            RtbUserInfo.Text = $"{currentUser.Name}\nRating: {currentUser.Rating}\nRating Deviation: {currentUser.RatingDeviation}\nRating Volatility: {currentUser.RatingVolatility}\n\nYou haven't played any online chess yet.";
        }

        private void ButtonPlayOnline_Click(object sender, EventArgs e)
        {
            var onlineSetupForm = new FormBoard(currentUser);
            onlineSetupForm.ShowDialog();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            var optionsForm = new FormOptions(currentUser);
            optionsForm.ShowDialog();
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            var statsForm = new FormStats();
            statsForm.ShowDialog();
        }

        private void ButtonPlayOffline_Click(object sender, EventArgs e)
        {
            var offlineSetupForm = new FormOfflineSetup(currentUser);
            offlineSetupForm.ShowDialog();
        }
    }
}
