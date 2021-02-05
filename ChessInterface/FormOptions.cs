using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ChessInterface
{
    public partial class FormOptions : Form
    {
        private User currentUser;

        private PictureBox[] piecePictureBoxes = new PictureBox[12];

        private Color lightColor;
        private Color LightColor
        {
            get => lightColor;
            set
            {
                lightColor = value;
                for (int i = 0; i < 12; i++)
                {
                    piecePictureBoxes[i].BackColor = i % 2 == 0 ? LightColor : DarkColor;
                }
            }
        }

        private Color darkColor;
        private Color DarkColor
        {
            get => darkColor;
            set
            {
                darkColor = value;
                for (int i = 0; i < 12; i++)
                {
                    piecePictureBoxes[i].BackColor = i % 2 == 0 ? LightColor : DarkColor;
                }
            }
        }

        private string chessSetPath;
        private string ChessSetPath
        {
            get => chessSetPath;
            set
            {
                LoadChessSet(value);
                chessSetPath = value;
            }
        }

        private FormOptions()
        {
            InitializeComponent();

            // How far apart picture boxes should be.
            const int pictureBoxDistance = 56;

            // Dynamically create picture boxes.
            for (int i = 0; i < 12; i++)
            {
                PictureBox newPictureBox = new PictureBox
                {
                    Location = new Point(13 + pictureBoxDistance * (i % 6), i < 6 ? 100 : 156),
                    Size = new Size(50, 50),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = i % 2 == 0 ? LightColor : DarkColor
                };

                piecePictureBoxes[i] = newPictureBox;
                GroupCustomSettings.Controls.Add(newPictureBox);
            }
        }
        
        private void ButtonLoadChessSet_Click(object sender, EventArgs e)
        {
            // Prompt the user to select a folder.
            FolderBrowserChessSet.Reset();
            FolderBrowserChessSet.Description = "Select a folder containing a chess set";
            FolderBrowserChessSet.ShowNewFolderButton = false;
            FolderBrowserChessSet.SelectedPath = TextChessSetPath.Text;
            FolderBrowserChessSet.ShowDialog();

            if (string.IsNullOrWhiteSpace(FolderBrowserChessSet.SelectedPath))
                return;

            // Load the files.
            try
            {
                LoadChessSet(FolderBrowserChessSet.SelectedPath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to locate a file.\n" + ex.Message + "\nA valid chess set contains 12 PNG files named bb, bk, bn, bp, bq, br, wb, wk, wn, wp, wq and wr.", "Error loading chess set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                throw;
            }

            TextChessSetPath.Text = FolderBrowserChessSet.SelectedPath;
            chessSetPath = FolderBrowserChessSet.SelectedPath;
            currentUser.ChessSetPath = TextChessSetPath.Text;
        }

        private void TextChessSetPath_Leave(object sender, EventArgs e)
        {
            try
            {
                LoadChessSet(TextChessSetPath.Text);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to locate a file.\n" + ex.Message + "\nA valid chess set contains 12 PNG files named bb, bk, bn, bp, bq, br, wb, wk, wn, wp, wq and wr.", "Error loading chess set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Loads a chess set from a folder.
        /// </summary>
        /// <param name="folder">The path containing the images representing the twelve different pieces.</param>
        private void LoadChessSet(string folder)
        {
            if (string.IsNullOrEmpty(folder))
            {
                Image[] defaultPieces =
                {
                    Properties.Resources.BlackPawn,
                    Properties.Resources.BlackKnight,
                    Properties.Resources.BlackBishop,
                    Properties.Resources.BlackRook,
                    Properties.Resources.BlackQueen,
                    Properties.Resources.BlackKing,
                    Properties.Resources.WhitePawn,
                    Properties.Resources.WhiteKnight,
                    Properties.Resources.WhiteBishop,
                    Properties.Resources.WhiteRook,
                    Properties.Resources.WhiteQueen,
                    Properties.Resources.WhiteKing
                };
                for (int i = 0; i < 12; i++)
                {
                    piecePictureBoxes[i].Image = defaultPieces[i];
                }
            }
            else
            {
                string[] pieces = { "bp.png", "bn.png", "bb.png", "br.png", "bq.png", "bk.png", "wp.png", "wn.png", "wb.png", "wr.png", "wq.png", "wk.png" };
                for (int i = 0; i < 12; i++)
                {
                    string piece = pieces[i];
                    piecePictureBoxes[i].Image = Image.FromFile(Path.Combine(folder, piece));
                }
            }
        }

        private void ButtonChangeLightColor_Click(object sender, EventArgs e)
        {
            ColorPicker.Color = LightColor;
            ColorPicker.ShowDialog();
            LightColor = ColorPicker.Color;
        }

        private void ButtonChangeDarkColor_Click(object sender, EventArgs e)
        {
            ColorPicker.Color = DarkColor;
            ColorPicker.ShowDialog();
            DarkColor = ColorPicker.Color;
        }

        public FormOptions(User user) : this()
        {
            currentUser = user;
            TextName.Text = user.Name;
            LightColor = user.LightColor;
            DarkColor = user.DarkColor;
            ChkAnnounceMoves.Checked = user.AnnounceMoves;
            TextChessSetPath.Text = user.ChessSetPath;
            
            LoadChessSet(TextChessSetPath.Text);

            TextChessSetPath.Enabled = !string.IsNullOrWhiteSpace(TextChessSetPath.Text);
            ButtonLoadChessSet.Enabled = !string.IsNullOrWhiteSpace(TextChessSetPath.Text);
        }

        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure chess set is valid
            if (CheckCustomChessSet.Checked)
            {
                string[] pieces = { "bp.png", "bn.png", "bb.png", "br.png", "bq.png", "bk.png", "wp.png", "wn.png", "wb.png", "wr.png", "wq.png", "wk.png" };
                foreach (var piece in pieces)
                {
                    if (!File.Exists(piece))
                    {
                        MessageBox.Show($"Invalid chess set. {piece} does not exist.\nA valid chess set contains 12 PNG files named bb, bk, bn, bp, bq, br, wb, wk, wn, wp, wq and wr.");
                        e.Cancel = true;
                        return;
                    }
                }
            }

            // Serialize the user object
            currentUser.Name = TextName.Text;
            currentUser.AnnounceMoves = ChkAnnounceMoves.Checked;
            currentUser.ChessSetPath = TextChessSetPath.Text;
            currentUser.LightColor = lightColor;
            currentUser.DarkColor = darkColor;
            File.WriteAllText("user.json", JsonConvert.SerializeObject(currentUser));
        }

        private void CheckCustomChessSet_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCustomChessSet.Checked)
            {
                TextChessSetPath.Enabled = true;
                ButtonLoadChessSet.Enabled = true;
            }
            else
            {
                TextChessSetPath.Text = null;
                TextChessSetPath.Enabled = false;
                ButtonLoadChessSet.Enabled = false;
                LoadChessSet(null);
            }
        }
    }
}
