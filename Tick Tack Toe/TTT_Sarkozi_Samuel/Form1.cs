using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TTT_Sarkozi_Samuel
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        bool dark = false;
        int pas = 0, runde = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            if (runde % 2 == 0)
            {
                pas = 0;
                curentPlayer.Text = "X";
                activePlayer.Text = "Active: Player 1";
            }
            else
            {
                pas = 1;
                curentPlayer.Text = "O";
                activePlayer.Text = "Active: Player 2";
            }
            if (runde == 10)
                runde = 0;
        }

        private void resetscore_Click(object sender, EventArgs e)
        {
            scor1.Text = "0";
            scor2.Text = "0";
            reset_Click(sender, e);
        }

        private void enterX(object sender, EventArgs e)
        {
            button_close.BackColor = Color.Red;
        }

        private void leaveX(object sender, EventArgs e)
        {
            if (dark)
            {
                button_close.BackColor = Color.FromArgb(20, 20, 20);
                button_close.ForeColor = Color.White;
            }
            else
            {
                button_close.BackColor = SystemColors.ControlDark;
                button_close.ForeColor = Color.Black;
            }
        }

        private void enterDark(object sender, EventArgs e)
        {
            if (dark)
            {
                darkMode.BackColor = SystemColors.ControlDark;
                darkMode.ForeColor = Color.Black;
            }
            else
            {
                darkMode.BackColor = Color.FromArgb(20, 20, 20);
                darkMode.ForeColor = Color.White;
            }
        }

        private void leaveDark(object sender, EventArgs e)
        {
            if (dark)
            {
                darkMode.BackColor = Color.FromArgb(20, 20, 20);
                darkMode.ForeColor = Color.White;
            }
            else
            {
                darkMode.BackColor = SystemColors.ControlDark;
                darkMode.ForeColor = Color.Black;
            }
        }

        private void butoane(object sender, EventArgs e)
        {
            Label curent = sender as Label;
            if (curent.Text != "")
                return;
            pas++;
            if (pas % 2 == 0)
            {
                curent.Text = "O";
                curentPlayer.Text = "X";
                activePlayer.Text = "Active: Player 1";
            }
            else
            {
                curent.Text = "X";
                curentPlayer.Text = "O";
                activePlayer.Text = "Active: Player 2";
            }

            //Verificare pe linii
            if ((label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != "") ||
                (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != "") ||
                (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != ""))
            {
                runde++;
                if (curent.Text == "X")
                {
                    MessageBox.Show("Player 1 a castigat !", "Tic Tac Toe");
                    reset_Click(sender, e);
                    scor1.Text = Convert.ToString(Convert.ToInt32(scor1.Text) + 1);
                }
                else
                {
                    MessageBox.Show("Player 2 a castigat !", "Tic Tac Toe");
                    reset_Click(sender, e);
                    scor2.Text = Convert.ToString(Convert.ToInt32(scor2.Text) + 1);
                }
            }

            //Verificare pe coloane
            if ((label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != "") ||
                (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != "") ||
                (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != ""))
            {
                runde++;
                if (curent.Text == "X")
                {
                    MessageBox.Show("Player 1 a castigat !", "Tic Tac Toe");
                    reset_Click(sender, e);
                    scor1.Text = Convert.ToString(Convert.ToInt32(scor1.Text) + 1);
                }
                else
                {
                    MessageBox.Show("Player 2 a castigat !", "Tic Tac Toe");
                    reset_Click(sender, e);
                    scor2.Text = Convert.ToString(Convert.ToInt32(scor2.Text) + 1);
                }
            }

            //Verificare pe diagonale
            if ((label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != "") ||
                (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != ""))
            {
                runde++;
                if (curent.Text == "X")
                {
                    MessageBox.Show("Player 1 a castigat !", "Tic Tac Toe");
                    reset_Click(sender, e);
                    scor1.Text = Convert.ToString(Convert.ToInt32(scor1.Text) + 1);
                }
                else
                {
                    MessageBox.Show("Player 2 a castigat !", "Tic Tac Toe");
                    reset_Click(sender, e);
                    scor2.Text = Convert.ToString(Convert.ToInt32(scor2.Text) + 1);
                }
            }

            //Remiza
            if ((pas == 9 && runde % 2 == 0) || (pas == 10 && runde % 2 != 0))
            {
                runde++;
                MessageBox.Show("Remiza !","Tic Tac Toe");
                reset_Click(sender, e);
            }
        }

        private void darkMode_Click(object sender, EventArgs e)
        {
            if (!dark)
            {
                ActiveForm.BackColor = Color.FromArgb(30, 30, 30);
                label1.BackColor = Color.FromArgb(60, 60, 60);
                label2.BackColor = Color.FromArgb(60, 60, 60);
                label3.BackColor = Color.FromArgb(60, 60, 60);
                label4.BackColor = Color.FromArgb(60, 60, 60);
                label5.BackColor = Color.FromArgb(60, 60, 60);
                label6.BackColor = Color.FromArgb(60, 60, 60);
                label7.BackColor = Color.FromArgb(60, 60, 60);
                label8.BackColor = Color.FromArgb(60, 60, 60);
                label9.BackColor = Color.FromArgb(60, 60, 60);

                button_close.BackColor = Color.FromArgb(20, 20, 20);
                button_close.ForeColor = Color.White;
                titleBar.BackColor = Color.FromArgb(20, 20, 20);
                titleBar.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                reset.ForeColor = Color.White;
                resetscore.ForeColor = Color.White;

                label10.ForeColor = Color.White;
                label_player1.ForeColor = Color.White;
                label_player2.ForeColor = Color.White;
                scor1.ForeColor = Color.White;
                scor2.ForeColor = Color.White;
                activePlayer.ForeColor = Color.White;
                curentPlayer.ForeColor = Color.White;

                copyright.ForeColor = Color.White;
                darkMode.BackColor = Color.FromArgb(20, 20, 20);
                darkMode.ForeColor = Color.White;
                darkMode.Text = "Light Mode";

                dark = true;
            }
            else
            {
                ActiveForm.BackColor = SystemColors.Control;
                label1.BackColor = SystemColors.ButtonShadow;
                label2.BackColor = SystemColors.ButtonShadow;
                label3.BackColor = SystemColors.ButtonShadow;
                label4.BackColor = SystemColors.ButtonShadow;
                label5.BackColor = SystemColors.ButtonShadow;
                label6.BackColor = SystemColors.ButtonShadow;
                label7.BackColor = SystemColors.ButtonShadow;
                label8.BackColor = SystemColors.ButtonShadow;
                label9.BackColor = SystemColors.ButtonShadow;

                button_close.BackColor = SystemColors.ControlDark;
                button_close.ForeColor = Color.Black;
                titleBar.BackColor = SystemColors.ControlDark;
                titleBar.ForeColor = Color.Black;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                reset.ForeColor = Color.Black;
                resetscore.ForeColor = Color.Black;

                label10.ForeColor = Color.Black;
                label_player1.ForeColor = Color.Black;
                label_player2.ForeColor = Color.Black;
                scor1.ForeColor = Color.Black;
                scor2.ForeColor = Color.Black;
                activePlayer.ForeColor = Color.Black;
                curentPlayer.ForeColor = Color.Black;

                copyright.ForeColor = Color.Black;
                darkMode.BackColor = SystemColors.ControlDark;
                darkMode.ForeColor = Color.Black;
                darkMode.Text = "Dark Mode";

                dark = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
