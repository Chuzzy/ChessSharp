using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessInterface
{
    public partial class FormOfflineSetup : Form
    {
        User currentUser;

        public FormOfflineSetup(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        
        private void FormOfflineSetup_Load(object sender, EventArgs e)
        {
            ComboPlayAs.Text = "Random color";
        }

        private void TrackBarDifficulty_Scroll(object sender, EventArgs e)
        {
            LabelComputerLevel.Text = "Level " + TrackBarDifficulty.Value;
        }

        private void ButtonStartComputer_Click(object sender, EventArgs e)
        {
            if (ComboPlayAs.Text == "Random color")
                ComboPlayAs.SelectedIndex = (new Random()).Next(2);

            var computerBoardForm = new FormComputerBoard(currentUser, TrackBarDifficulty.Value, ComboPlayAs.Text);
            Hide();
            computerBoardForm.ShowDialog();
            Show();
        }

        private void ButtonStart2Player_Click(object sender, EventArgs e)
        {
            var form2PlayerBoard = new Form2PlayerBoard(currentUser, (int)NumTimeControlMins.Value * 60 * 1000, (int)NumTimeControlIncrement.Value * 1000);
            Hide();
            form2PlayerBoard.ShowDialog();
            Show();
        }
    }
}
