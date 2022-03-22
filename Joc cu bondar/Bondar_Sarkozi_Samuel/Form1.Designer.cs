namespace Bondar_Sarkozi_Samuel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.fundal = new System.Windows.Forms.Panel();
            this.msg_lose = new System.Windows.Forms.Label();
            this.floare2 = new System.Windows.Forms.PictureBox();
            this.viespe2 = new System.Windows.Forms.PictureBox();
            this.floare1 = new System.Windows.Forms.PictureBox();
            this.viespe1 = new System.Windows.Forms.PictureBox();
            this.bondar = new System.Windows.Forms.PictureBox();
            this.v3 = new System.Windows.Forms.PictureBox();
            this.v2 = new System.Windows.Forms.PictureBox();
            this.v1 = new System.Windows.Forms.PictureBox();
            this.pct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msg_win = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.msg_pause = new System.Windows.Forms.Label();
            this.fundal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floare2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viespe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floare1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viespe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bondar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fundal
            // 
            this.fundal.BackColor = System.Drawing.SystemColors.Control;
            this.fundal.BackgroundImage = global::Bondar_Sarkozi_Samuel.Properties.Resources.background;
            this.fundal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fundal.Controls.Add(this.msg_pause);
            this.fundal.Controls.Add(this.exit);
            this.fundal.Controls.Add(this.reset);
            this.fundal.Controls.Add(this.msg_win);
            this.fundal.Controls.Add(this.msg_lose);
            this.fundal.Controls.Add(this.floare2);
            this.fundal.Controls.Add(this.viespe2);
            this.fundal.Controls.Add(this.floare1);
            this.fundal.Controls.Add(this.viespe1);
            this.fundal.Controls.Add(this.bondar);
            this.fundal.Controls.Add(this.v3);
            this.fundal.Controls.Add(this.v2);
            this.fundal.Controls.Add(this.v1);
            this.fundal.Controls.Add(this.pct);
            this.fundal.Controls.Add(this.label1);
            this.fundal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundal.Location = new System.Drawing.Point(0, 0);
            this.fundal.Name = "fundal";
            this.fundal.Size = new System.Drawing.Size(784, 561);
            this.fundal.TabIndex = 0;
            // 
            // msg_lose
            // 
            this.msg_lose.BackColor = System.Drawing.Color.Red;
            this.msg_lose.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lose.Location = new System.Drawing.Point(-6, 223);
            this.msg_lose.Name = "msg_lose";
            this.msg_lose.Size = new System.Drawing.Size(800, 100);
            this.msg_lose.TabIndex = 8;
            this.msg_lose.Text = "Ai rămas fără vieți !";
            this.msg_lose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msg_lose.Visible = false;
            // 
            // floare2
            // 
            this.floare2.BackColor = System.Drawing.Color.Transparent;
            this.floare2.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.flower;
            this.floare2.Location = new System.Drawing.Point(471, 253);
            this.floare2.Name = "floare2";
            this.floare2.Size = new System.Drawing.Size(100, 80);
            this.floare2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floare2.TabIndex = 11;
            this.floare2.TabStop = false;
            this.floare2.Tag = "floare";
            // 
            // viespe2
            // 
            this.viespe2.BackColor = System.Drawing.Color.Transparent;
            this.viespe2.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.angry_bee;
            this.viespe2.Location = new System.Drawing.Point(654, 223);
            this.viespe2.Name = "viespe2";
            this.viespe2.Size = new System.Drawing.Size(100, 123);
            this.viespe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viespe2.TabIndex = 9;
            this.viespe2.TabStop = false;
            this.viespe2.Tag = "viespe";
            // 
            // floare1
            // 
            this.floare1.BackColor = System.Drawing.Color.Transparent;
            this.floare1.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.flower;
            this.floare1.Location = new System.Drawing.Point(480, 95);
            this.floare1.Name = "floare1";
            this.floare1.Size = new System.Drawing.Size(100, 80);
            this.floare1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floare1.TabIndex = 2;
            this.floare1.TabStop = false;
            this.floare1.Tag = "floare";
            // 
            // viespe1
            // 
            this.viespe1.BackColor = System.Drawing.Color.Transparent;
            this.viespe1.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.angry_bee;
            this.viespe1.Location = new System.Drawing.Point(654, 94);
            this.viespe1.Name = "viespe1";
            this.viespe1.Size = new System.Drawing.Size(100, 123);
            this.viespe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viespe1.TabIndex = 1;
            this.viespe1.TabStop = false;
            this.viespe1.Tag = "viespe";
            // 
            // bondar
            // 
            this.bondar.BackColor = System.Drawing.Color.Transparent;
            this.bondar.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.bondar;
            this.bondar.Location = new System.Drawing.Point(314, 58);
            this.bondar.Name = "bondar";
            this.bondar.Size = new System.Drawing.Size(121, 96);
            this.bondar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bondar.TabIndex = 0;
            this.bondar.TabStop = false;
            // 
            // v3
            // 
            this.v3.BackColor = System.Drawing.Color.Transparent;
            this.v3.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.heart;
            this.v3.Location = new System.Drawing.Point(156, 48);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(63, 45);
            this.v3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.v3.TabIndex = 7;
            this.v3.TabStop = false;
            // 
            // v2
            // 
            this.v2.BackColor = System.Drawing.Color.Transparent;
            this.v2.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.heart;
            this.v2.Location = new System.Drawing.Point(87, 48);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(63, 45);
            this.v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.v2.TabIndex = 6;
            this.v2.TabStop = false;
            // 
            // v1
            // 
            this.v1.BackColor = System.Drawing.Color.Transparent;
            this.v1.Image = global::Bondar_Sarkozi_Samuel.Properties.Resources.heart;
            this.v1.Location = new System.Drawing.Point(18, 48);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(63, 45);
            this.v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.v1.TabIndex = 5;
            this.v1.TabStop = false;
            // 
            // pct
            // 
            this.pct.AutoSize = true;
            this.pct.BackColor = System.Drawing.Color.Transparent;
            this.pct.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pct.Location = new System.Drawing.Point(161, 9);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(36, 36);
            this.pct.TabIndex = 4;
            this.pct.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puncte:";
            // 
            // msg_win
            // 
            this.msg_win.BackColor = System.Drawing.Color.Lime;
            this.msg_win.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_win.Location = new System.Drawing.Point(-8, 223);
            this.msg_win.Name = "msg_win";
            this.msg_win.Size = new System.Drawing.Size(800, 100);
            this.msg_win.TabIndex = 12;
            this.msg_win.Text = "Ai câștigat !";
            this.msg_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msg_win.Visible = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Orange;
            this.reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reset.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(251, 333);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(140, 42);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Orange;
            this.exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(397, 333);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 42);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // msg_pause
            // 
            this.msg_pause.BackColor = System.Drawing.Color.DarkGray;
            this.msg_pause.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_pause.Location = new System.Drawing.Point(-8, 223);
            this.msg_pause.Name = "msg_pause";
            this.msg_pause.Size = new System.Drawing.Size(800, 100);
            this.msg_pause.TabIndex = 15;
            this.msg_pause.Text = "Pauză";
            this.msg_pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msg_pause.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.fundal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bondar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.fundal.ResumeLayout(false);
            this.fundal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floare2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viespe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floare1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viespe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bondar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fundal;
        private System.Windows.Forms.PictureBox bondar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox viespe1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox floare1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pct;
        private System.Windows.Forms.PictureBox v1;
        private System.Windows.Forms.PictureBox v3;
        private System.Windows.Forms.PictureBox v2;
        private System.Windows.Forms.Label msg_lose;
        private System.Windows.Forms.PictureBox viespe2;
        private System.Windows.Forms.PictureBox floare2;
        private System.Windows.Forms.Label msg_win;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label reset;
        private System.Windows.Forms.Label msg_pause;
    }
}

