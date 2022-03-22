using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondar_Sarkozi_Samuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random v = new Random();
            Random f = new Random();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            viespe1.Left = 0;
            viespe1.Top = v.Next(0, 300);
            viespe2.Left = 0;
            viespe2.Top = v.Next(500, 700);

            floare1.Left = 0;
            floare1.Top = f.Next(0, 300);
            floare2.Left = 0;
            floare2.Top = f.Next(500, 700);
            SetDoubleBuffered(fundal);
            viespe1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            viespe2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        bool left = false;
        bool right = false;
        bool up = false;

        int viteza = 10;
        int gravitatie = 5;
        int vieti = 3;
        int puncte = 0;

        bool esc = false;
        bool done = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.Escape && !done)
            {
                if(!esc)
                {
                    esc = true;
                    msg_pause.Left = 0;
                    msg_pause.Width = this.Width;
                    msg_pause.Top = (this.Height - msg_lose.Height) / 2;
                    msg_pause.Visible = true;
                    reset.Top = msg_pause.Top + msg_pause.Height + 10;
                    exit.Top = msg_pause.Top + msg_pause.Height + 10;
                    reset.Left = this.Width / 2 - reset.Width - 10;
                    exit.Left = reset.Left + reset.Width + 10;
                    exit.Visible = true;
                    reset.Visible = true;
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                }
                else
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    esc = false;
                    msg_pause.Visible = false;
                    exit.Visible = false;
                    reset.Visible = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Up)
                up = false;
        }

        bool isLeft = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //player = bondar
            if (bondar.Top < this.Height - bondar.Height - 90 && !up)
                bondar.Top += gravitatie;

            #region Left, Right, Up && Roteste albina
            if (left && bondar.Left > 4)
            {
                bondar.Left -= viteza;
                if (!isLeft)
                {
                    isLeft = true;
                    bondar.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
            }
            if (right && bondar.Left < this.Width - bondar.Width - 15)
            {
                bondar.Left += viteza;
                if (isLeft)
                {
                    isLeft = false;
                    bondar.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
            }
            if (up && bondar.Top >= 4)
                bondar.Top -= viteza;
            #endregion

            if(Convert.ToInt32(pct.Text) >= 25)
            {
                msg_win.Left = 0;
                msg_win.Width = this.Width;
                msg_win.Top = (this.Height - msg_win.Height) / 2;
                msg_win.Visible = true;
                reset.Top = msg_win.Top + msg_win.Height + 10;
                exit.Top = msg_win.Top + msg_win.Height + 10;
                reset.Left = this.Width / 2 - reset.Width - 10;
                exit.Left = reset.Left + reset.Width + 10;
                exit.Visible = true;
                reset.Visible = true;
                done = true;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
            }

            foreach(Control x in fundal.Controls)
            {
                if((x.Bounds.IntersectsWith(viespe1.Bounds) || x.Bounds.IntersectsWith(viespe2.Bounds)) && x.Tag=="floare")
                {
                    Random y = new Random();
                    x.Left = this.Width;
                    x.Top = y.Next(0, this.Height - 200);
                }
                if (bondar.Bounds.IntersectsWith(x.Bounds))
                {
                    if (x.Tag == "viespe")
                    {
                        Random y = new Random();
                        x.Left = this.Width;
                        x.Top = y.Next(0, this.Height - 200);
                        vieti--;
                        switch (vieti)
                        {
                            case 2:
                                v3.Visible = false;
                                break;
                            case 1:
                                v2.Visible = false;
                                break;
                            case 0:
                                v1.Visible = false;
                                msg_lose.Left = 0;
                                msg_lose.Width = this.Width;
                                msg_lose.Top = (this.Height - msg_lose.Height) / 2;
                                msg_lose.Visible = true;
                                reset.Top = msg_lose.Top + msg_lose.Height + 10;
                                exit.Top = msg_lose.Top + msg_lose.Height + 10;
                                reset.Left = this.Width / 2 - reset.Width - 10;
                                exit.Left = reset.Left + reset.Width + 10;
                                exit.Visible = true;
                                reset.Visible = true;
                                done = true;
                                timer1.Stop();
                                timer2.Stop();
                                timer3.Stop();
                                break;
                        }
                    }
                    if (x.Tag == "floare")
                    {
                        pct.Text = Convert.ToString(Convert.ToInt32(pct.Text) + 1);
                        x.Left = this.Width;
                        Random y = new Random();
                        x.Left = this.Width;
                        x.Top = y.Next(0, this.Height - 200);
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //viespe
            if (viespe1.Left > 0)
                viespe1.Left -= 20;
            else
            {
                Random l = new Random();
                viespe1.Left = this.Width + 200;
                viespe1.Top = l.Next(0, this.Height / 2 - 25);
            }
            if (viespe2.Left > 0)
                viespe2.Left -= 15;
            else
            {
                Random l = new Random();
                viespe2.Left = this.Width;
                viespe2.Top = l.Next(this.Height / 2, this.Height - viespe2.Height - 25);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(floare1.Left > 0)
                floare1.Left -= 13;
            else
            {
                Random l = new Random();
                floare1.Left = this.Width;
                floare1.Top = l.Next(0, this.Height - floare1.Height - 25);
            }
            if (floare2.Left > 0)
                floare2.Left -= 10;
            else
            {
                Random l = new Random();
                floare2.Left = this.Width + 200;
                floare2.Top = l.Next(this.Height / 2, this.Height - floare2.Height - 25);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset.Visible = false;
            exit.Visible = false;
            msg_lose.Visible = false;
            msg_win.Visible = false;
            msg_pause.Visible = false;
            esc = false;
            done = false;
            pct.Text = "0";
            vieti = 3;
            v1.Visible = true;
            v2.Visible = true;
            v3.Visible = true;
            floare1.Left = 0;
            floare2.Left = 0;
            viespe1.Left = 0;
            viespe2.Left = 0;
            bondar.Left = 30;
            bondar.Top = 70;
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        // --------------------

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        // --------------------
    }
}
