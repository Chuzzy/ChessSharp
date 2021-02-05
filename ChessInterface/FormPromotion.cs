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
    public partial class FormPromotion : Form
    {
        public string PromotedTo = " ";

        public FormPromotion(User currentUser, bool whitePieces, string message)
        {
            InitializeComponent();

            Text = message;
            if (!whitePieces)
            {
                ButtonQueen.BackgroundImage = Properties.Resources.BlackQueen;
                ButtonRook.BackgroundImage = Properties.Resources.BlackRook;
                ButtonBishop.BackgroundImage = Properties.Resources.BlackBishop;
                ButtonKnight.BackgroundImage = Properties.Resources.BlackKnight;
            }
        }

        private void ButtonQueen_Click(object sender, EventArgs e)
        {
            PromotedTo = "Q";
            Close();
        }

        private void ButtonRook_Click(object sender, EventArgs e)
        {
            PromotedTo = "R";
            Close();
        }

        private void ButtonBishop_Click(object sender, EventArgs e)
        {
            PromotedTo = "B";
            Close();
        }

        private void ButtonKnight_Click(object sender, EventArgs e)
        {
            PromotedTo = "N";
            Close();
        }
    }
}
