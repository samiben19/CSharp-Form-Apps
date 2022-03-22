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

namespace Calculator_Sarkozi_Samuel
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg,
        int Param1, int Param2);

        public Form1()
        {
            InitializeComponent();
        }

        double nr1, nr2;
        double rez = 0;
        bool dark = false, rezolvat = false, point = false, zeroFirst = false;
        int op = 0, lung = 0;
                    // 1 +
                    // 2 -
                    // 3 *
                    // 4 /
                    // 5 ^
                    // 6 % (mod)
                    // size 344 419

        private void numberClick(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            Button button = sender as Button;

            if (zeroFirst && ecran.Text == "0")
            {
                ecran.Text = button.Text;
                zeroFirst = false;
            }
            else
                ecran.Text = ecran.Text + button.Text;

            if (button.Text == "0" && ecran.Text == "0")
                zeroFirst = true;
        }

        private void button_egal_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "")
                return;
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (op == 0)
                return;
            nr2 = Convert.ToDouble(ecran.Text);
            istoric.Text = istoric.Text + Convert.ToString(nr2) + " = ";
            ecran.Text = "";
            switch(op)
            {
                case 1:
                    rez = rez + nr2;
                    break;
                case 2:
                    rez = rez - nr2;
                    break;
                case 3:
                    rez = rez * nr2;
                    break;
                case 4:
                    if (nr2 == 0)
                    {
                        lung += +Convert.ToString(nr2).Length + 3;
                        string s = istoric.Text;
                        s = s.Substring(0, s.Length - lung);
                        istoric.Text = s;
                        ecran.Text = "Invalid";
                    }
                    else
                        rez = rez / nr2;
                    break;
                case 5:
                    rez = Math.Pow(nr1, nr2);
                    break;
                case 6:
                    if (nr2 == 0)
                    {
                        lung += +Convert.ToString(nr2).Length + 3;
                        string s = istoric.Text;
                        s = s.Substring(0, s.Length - lung);
                        istoric.Text = s;
                        ecran.Text = "Invalid";
                    }
                    else
                        rez = nr1 % nr2;
                    break;
                default:
                    return;
            }
            if (nr2 != 0)
            {
                ecran.Text = Convert.ToString(rez);
                istoric.Text = istoric.Text + ecran.Text + "\r\n";
            }
            rez = 0;
            op = 0;
            rezolvat = true;
            point = false;
            lung = 0;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (ecran.Text == "" || ecran.Text == "-")
                return;
            if (op == 3 || op == 4 || op == 5 || op == 6)
                return;
            nr1 = Convert.ToDouble(ecran.Text);
            switch (op)
            {
                case 0:
                    rez = nr1;
                    break;
                case 1:
                    rez += nr1;
                    break;
                case 2:
                    rez -= nr1;
                    break;
                case 3:
                    rez *= nr1;
                    break;
                case 4:
                    rez /= nr1;
                    break;
            }
            istoric.Text = istoric.Text + Convert.ToString(nr1) + " + ";
            lung += Convert.ToString(nr1).Length + 3;
            ecran.Text = "";
            op = 1;
            point = false;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (ecran.Text == "")
            {
                ecran.Text = "-";
                return;
            }
            else
                if (ecran.Text == "-")
                {
                    ecran.Text = "";
                    return;
                }
            if (op == 3 || op == 4 || op == 5 || op == 6)
                return;
            nr1 = Convert.ToDouble(ecran.Text);
            switch (op)
            {
                case 0:
                    rez = nr1;
                    break;
                case 1:
                    rez += nr1;
                    break;
                case 2:
                    rez -= nr1;
                    break;
                case 3:
                    rez *= nr1;
                    break;
                case 4:
                    rez /= nr1;
                    break;
            }
            istoric.Text = istoric.Text + Convert.ToString(nr1) + " - ";
            lung += Convert.ToString(nr1).Length + 3;
            ecran.Text = "";
            op = 2;
            point = false;
        }

        private void button_ori_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (op == 1 || op == 2 || op == 5 || op == 6)
                return;
            if (ecran.Text == "" || ecran.Text == "-")
                return;
            nr1 = Convert.ToDouble(ecran.Text);
            switch (op)
            {
                case 0:
                    rez = nr1;
                    break;
                case 1:
                    rez += nr1;
                    break;
                case 2:
                    rez -= nr1;
                    break;
                case 3:
                    rez *= nr1;
                    break;
                case 4:
                    rez /= nr1;
                    break;
            }
            istoric.Text = istoric.Text + Convert.ToString(nr1) + " * ";
            lung += Convert.ToString(nr1).Length + 3;
            ecran.Text = "";
            op = 3;
            point = false;
        }

        private void button_impartire_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (op == 1 || op == 2 || op == 5 || op == 6)
                return;
            if (ecran.Text == "" || ecran.Text == "-")
                return;
            nr1 = Convert.ToDouble(ecran.Text);
            switch (op)
            {
                case 0:
                    rez = nr1;
                    break;
                case 1:
                    rez += nr1;
                    break;
                case 2:
                    rez -= nr1;
                    break;
                case 3:
                    rez *= nr1;
                    break;
                case 4:
                    rez /= nr1;
                    break;
            }
            istoric.Text = istoric.Text + Convert.ToString(nr1) + " / ";
            lung += Convert.ToString(nr1).Length + 3;
            ecran.Text = "";
            op = 4;
            point = false;
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (op == 1 || op == 2 || op == 5 || op == 6)
                return;
            if (ecran.Text == "" || ecran.Text == "-")
                return;
            nr1 = Convert.ToDouble(ecran.Text);
            istoric.Text = istoric.Text + Convert.ToString(nr1) + " % ";
            lung += Convert.ToString(nr1).Length + 3;
            ecran.Text = "";
            op = 6;
            point = false;
        }

        private void button_procent_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (op == 0 || op > 5 || ecran.Text == "" || ecran.Text == "-")
                return;
            nr2 = Convert.ToDouble(ecran.Text);

            istoric.Text += Convert.ToString(nr2 / 100 * nr1) + " = ";
            switch(op)
            {
                case 1:
                    rez = nr1 + (nr2 / 100 * nr1);
                    break;
                case 2:
                    rez = nr1 - (nr2 / 100 * nr1);
                    break;
                case 3:
                    rez = nr1 * (nr2 / 100 * nr1);
                    break;
                case 4:
                    rez = nr1 / (nr2 / 100 * nr1);
                    break;
                default:
                    return;
            }
            istoric.Text += Convert.ToString(rez) + "\r\n";
            ecran.Text = Convert.ToString(rez);
            rez = 0;
            op = 0;
            rezolvat = true;
            point = false;
            ecran.Text = "";
        }

        private void button_radical_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (ecran.Text == "" || ecran.Text == "-")
                return;
            if (op >= 1 && op <= 6)
                return;

            nr1 = Convert.ToDouble(ecran.Text);
            if (nr1 < 0)
            {
                ecran.Text = "Invalid";
                rezolvat = true;
                return;
            }
            istoric.Text += "√" + Convert.ToString(nr1) + " = ";
            rez = (double)Math.Sqrt(nr1);
            istoric.Text += Convert.ToString(rez) + '\n';
            ecran.Text = Convert.ToString(rez);
            rez = 0;
            rezolvat = true;
            point = false;
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (ecran.Text == "" || ecran.Text== "-")
                return;
            if (op >= 1 && op <= 6)
                return;

            nr1 = Convert.ToDouble(ecran.Text);
            if (point && !Equals(nr1,Math.Round(nr1)))
            {
                ecran.Text = "Invalid";
                rezolvat = true;
                point = false;
                return;
            }

            if (nr1 < 0)
            {
                ecran.Text = "Invalid";
                rezolvat = true;
                return;
            }
            istoric.Text += Convert.ToString(nr1) + "! = ";
            rez = 1;
            for (int i = 1; i <= nr1; i++)
                rez *= i;
            istoric.Text += Convert.ToString(rez) + '\n';
            ecran.Text = Convert.ToString(rez);
            rez = 0;
            rezolvat = true;
            point = false;
        }

        private void button_putere_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (op >= 1 && op <= 6)
                return;
            if (ecran.Text == "" || ecran.Text == "-")
                return;
            nr1 = Convert.ToDouble(ecran.Text);
            istoric.Text += Convert.ToString(nr1) + "^";
            ecran.Text = "";
            op = 5;
            point = false;
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            point = true;
            if(ecran.Text == "-")
                ecran.Text += Convert.ToString(Math.PI);
            else
                ecran.Text = Convert.ToString(Math.PI);
        }

        private void button_e_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            point = true;
            if (ecran.Text == "-")
                ecran.Text += Convert.ToString(Math.E);
            else
                ecran.Text = Convert.ToString(Math.E);
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

        private void button_close_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ecran.Text = "";
            istoric.Text = "";
            nr1 = 0;
            nr2 = 0;
            rez = 0;
            op = 0;
            lung = 0;
            rezolvat = false;
            point = false;

        }

        private void button_punct_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            if (ecran.Text == "")
                ecran.Text = "0.";
            else if (ecran.Text == "-")
                ecran.Text = "-0.";
            else if (!point)
                ecran.Text += ".";
            point = true;
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            if (rezolvat)
            {
                ecran.Text = "";
                rezolvat = false;
            }
            string s = ecran.Text;

            if (s.Length > 0)
                s = s.Substring(0, s.Length - 1);

            bool ok = true;

            for (int i = 0; i < s.Length; i++)
                if (s[i] == '.')
                    ok = false;
            if (ok)
                point = false;
            else
                point = true;

            ecran.Text = s;
        }
        
        private void darkMode_Click(object sender, EventArgs e)
        {
            if (!dark)
            {
                ActiveForm.BackColor = Color.FromArgb(30, 30, 30);
                button1.BackColor = Color.FromArgb(60, 60, 60);
                button2.BackColor = Color.FromArgb(60, 60, 60);
                button3.BackColor = Color.FromArgb(60, 60, 60);
                button4.BackColor = Color.FromArgb(60, 60, 60);
                button5.BackColor = Color.FromArgb(60, 60, 60);
                button6.BackColor = Color.FromArgb(60, 60, 60);
                button7.BackColor = Color.FromArgb(60, 60, 60);
                button8.BackColor = Color.FromArgb(60, 60, 60);
                button9.BackColor = Color.FromArgb(60, 60, 60);
                button0.BackColor = Color.FromArgb(60, 60, 60);

                ecran.BackColor = Color.FromArgb(20, 20, 20);
                ecran.ForeColor = Color.White;

                button_clear.BackColor = Color.FromArgb(10, 10, 10);
                button_plus.BackColor = Color.FromArgb(10, 10, 10);
                button_minus.BackColor = Color.FromArgb(10, 10, 10);
                button_ori.BackColor = Color.FromArgb(10, 10, 10);
                button_impartire.BackColor = Color.FromArgb(10, 10, 10);
                button_egal.BackColor = Color.FromArgb(10, 10, 10);
                button_undo.BackColor = Color.FromArgb(10, 10, 10);
                button_punct.BackColor = Color.FromArgb(10, 10, 10);
                button_factorial.BackColor = Color.FromArgb(10, 10, 10);
                button_radical.BackColor = Color.FromArgb(10, 10, 10);
                button_pi.BackColor = Color.FromArgb(10, 10, 10);
                button_putere.BackColor = Color.FromArgb(10, 10, 10);
                button_e.BackColor = Color.FromArgb(10, 10, 10);
                button_mod.BackColor = Color.FromArgb(10, 10, 10);
                button_procent.BackColor = Color.FromArgb(10, 10, 10);

                button_close.BackColor = Color.FromArgb(20, 20, 20);
                button_close.ForeColor = Color.White;
                titleBar.BackColor = Color.FromArgb(20, 20, 20);
                titleBar.ForeColor = Color.White;

                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
                button6.ForeColor = Color.White;
                button7.ForeColor = Color.White;
                button8.ForeColor = Color.White;
                button9.ForeColor = Color.White;
                button0.ForeColor = Color.White;

                button_plus.ForeColor = Color.White;
                button_minus.ForeColor = Color.White;
                button_ori.ForeColor = Color.White;
                button_impartire.ForeColor = Color.White;
                button_clear.ForeColor = Color.White;
                button_egal.ForeColor = Color.White;
                button_undo.ForeColor = Color.White;
                button_punct.ForeColor = Color.White;
                button_factorial.ForeColor = Color.White;
                button_radical.ForeColor = Color.White;
                button_pi.ForeColor = Color.White;
                button_putere.ForeColor = Color.White;
                button_e.ForeColor = Color.White;
                button_mod.ForeColor = Color.White;
                button_procent.ForeColor = Color.White;
                darkMode.ForeColor = Color.White;

                copyright.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                istoric.BackColor = Color.FromArgb(30, 30, 30);
                istoric.ForeColor = Color.White;

                darkMode.Text = "Light Mode";
                darkMode.ForeColor = Color.White;

                dark = true;
            }
            else
            {
                ActiveForm.BackColor = SystemColors.Control;
                button1.BackColor = SystemColors.Control;
                button2.BackColor = SystemColors.Control;
                button3.BackColor = SystemColors.Control;
                button4.BackColor = SystemColors.Control;
                button5.BackColor = SystemColors.Control;
                button6.BackColor = SystemColors.Control;
                button7.BackColor = SystemColors.Control;
                button8.BackColor = SystemColors.Control;
                button9.BackColor = SystemColors.Control;
                button0.BackColor = SystemColors.Control;

                ecran.BackColor = SystemColors.ScrollBar;
                ecran.ForeColor = Color.Black;

                button_clear.BackColor = SystemColors.ControlDark;
                button_plus.BackColor = SystemColors.ControlDark;
                button_minus.BackColor = SystemColors.ControlDark;
                button_ori.BackColor = SystemColors.ControlDark;
                button_impartire.BackColor = SystemColors.ControlDark;
                button_egal.BackColor = SystemColors.ControlDark;
                button_undo.BackColor = SystemColors.ControlDark;
                button_punct.BackColor = SystemColors.ControlDark;
                button_factorial.BackColor = SystemColors.ControlDark;
                button_radical.BackColor = SystemColors.ControlDark;
                button_pi.BackColor = SystemColors.ControlDark;
                button_putere.BackColor = SystemColors.ControlDark;
                button_e.BackColor = SystemColors.ControlDark;
                button_mod.BackColor = SystemColors.ControlDark;
                button_procent.BackColor = SystemColors.ControlDark;

                button_close.BackColor = SystemColors.ControlDark;
                button_close.ForeColor = Color.Black;
                titleBar.BackColor = SystemColors.ControlDark;
                titleBar.ForeColor = Color.Black;

                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button0.ForeColor = Color.Black;

                button_plus.ForeColor = Color.Black;
                button_minus.ForeColor = Color.Black;
                button_ori.ForeColor = Color.Black;
                button_impartire.ForeColor = Color.Black;
                button_clear.ForeColor = Color.Black;
                button_egal.ForeColor = Color.Black;
                button_undo.ForeColor = Color.Black;
                button_punct.ForeColor = Color.Black;
                button_radical.ForeColor = Color.Black;
                button_factorial.ForeColor = Color.Black;
                button_pi.ForeColor = Color.Black;
                button_putere.ForeColor = Color.Black;
                button_e.ForeColor = Color.Black;
                button_mod.ForeColor = Color.Black;
                button_procent.ForeColor = Color.Black;
                darkMode.ForeColor = Color.Black;

                copyright.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                istoric.BackColor = SystemColors.Control;
                istoric.ForeColor = Color.Black;

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
