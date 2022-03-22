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

namespace Chibrite_Sarkozi_Samuel
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        bool player1 = true;
        int chib_ramase = 16, runde;

        public Form1()
        {
            InitializeComponent();
        }

        private void chibrite(object sender, EventArgs e)
        {
            PictureBox curent = sender as PictureBox;
            curent.Visible = false;
            chib_ramase--;
            kchib.Text = Convert.ToString(chib_ramase);

            if (curent == chib11)
                foreach (Control x in this.Controls)
                    if (x is PictureBox && x != curent)
                        ((PictureBox)x).Enabled = false;

            if(curent == chib21 || curent == chib22 || curent == chib23)
                foreach (Control x in this.Controls)
                    if (x is PictureBox && (x != curent && x != chib21 && x != chib22 && x != chib23))
                        //((PictureBox)x).Visible = false;
                        ((PictureBox)x).Enabled = false;

            if (curent == chib31 || curent == chib32 || curent == chib33 || curent == chib34 || curent == chib35)
                foreach (Control x in this.Controls)
                    if (x is PictureBox && (x != curent && x != chib31 && x != chib32 && x != chib33 && x != chib34 && x != chib35))
                        ((PictureBox)x).Enabled = false;

            if (curent == chib41 || curent == chib42 || curent == chib43 || curent == chib44 || curent == chib45 || curent == chib46 || curent == chib47)
                foreach (Control x in this.Controls)
                    if (x is PictureBox && (x != curent && x != chib41 && x != chib42 && x != chib43 && x != chib44 && x != chib45 && x != chib46 && x != chib47))
                        ((PictureBox)x).Enabled = false;

            if (chib_ramase == 1)
            {
                if (player1)
                {
                    MessageBox.Show("Player 1 a câștigat !", "Chibrite");
                    p1.Text = Convert.ToString(Convert.ToInt32(p1.Text) + 1);
                }
                else
                {
                    MessageBox.Show("Player 2 a câștigat !", "Chibrite");
                    p2.Text = Convert.ToString(Convert.ToInt32(p2.Text) + 1);
                }
                runde++;
                reset_Click(sender, e);
                return;
            }

            next.Visible = true;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (player1)
            {
                player1 = false;
                playerCurent.Text = "2";
            }
            else
            {
                player1 = true;
                playerCurent.Text = "1";
            }

            foreach (Control x in this.Controls)
                if(x is PictureBox)
                    ((PictureBox)x).Enabled = true;

            next.Visible = false;
        }

        private void enterX(object sender, EventArgs e)
        {
            button_close.BackColor = Color.Red;
        }

        private void leaveX(object sender, EventArgs e)
        {
            button_close.BackColor = Color.FromArgb(10, 10, 10);
            button_close.ForeColor = Color.White;
        }

        private void close(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            next.Visible = false;
            foreach (Control x in this.Controls)
                if (x is PictureBox)
                {
                    ((PictureBox)x).Visible = true;
                    ((PictureBox)x).Enabled = true;
                }
            chib_ramase = 16;
            kchib.Text = Convert.ToString(chib_ramase);
            if(runde%2==0)
            {
                player1 = true;
                playerCurent.Text = "1";
            }
            else
            {
                player1 = false;
                playerCurent.Text = "2";
            }
            if (runde == 10)
                runde = 0;
        }

        private void enterScore(object sender, EventArgs e)
        {
            label5.Location = new Point(236, 485);
            label5.Text = "Resetează scorul";
            label5.ForeColor = Color.Red;
        }

        private void leaveScore(object sender, EventArgs e)
        {
            label5.Location = new Point(286, 485);
            label5.Text = "Scor";
            label5.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            p1.Text = "0";
            p2.Text = "0";
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
