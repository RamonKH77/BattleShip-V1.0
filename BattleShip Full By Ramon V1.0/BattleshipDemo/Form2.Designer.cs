namespace BattleshipDemo
{
    partial class Form2
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
            this.Score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsernameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerL = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(151, 1143);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(97, 32);
            this.Score.TabIndex = 240;
            this.Score.Text = "Score:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.playAgainToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 52);
            this.menuStrip1.TabIndex = 241;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeUsernameToolStripMenuItem1,
            this.changeGameModeToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 45);
            this.exitToolStripMenuItem.Text = "Customize";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(481, 46);
            this.changeColorToolStripMenuItem.Text = "Change Background Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // changeUsernameToolStripMenuItem1
            // 
            this.changeUsernameToolStripMenuItem1.Name = "changeUsernameToolStripMenuItem1";
            this.changeUsernameToolStripMenuItem1.Size = new System.Drawing.Size(481, 46);
            this.changeUsernameToolStripMenuItem1.Text = "Change Username";
            this.changeUsernameToolStripMenuItem1.Click += new System.EventHandler(this.changeUsernameToolStripMenuItem1_Click);
            // 
            // changeGameModeToolStripMenuItem
            // 
            this.changeGameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeRunToolStripMenuItem,
            this.clickLimitToolStripMenuItem});
            this.changeGameModeToolStripMenuItem.Name = "changeGameModeToolStripMenuItem";
            this.changeGameModeToolStripMenuItem.Size = new System.Drawing.Size(481, 46);
            this.changeGameModeToolStripMenuItem.Text = "Change Game Mode";
            // 
            // timeRunToolStripMenuItem
            // 
            this.timeRunToolStripMenuItem.Name = "timeRunToolStripMenuItem";
            this.timeRunToolStripMenuItem.Size = new System.Drawing.Size(266, 46);
            this.timeRunToolStripMenuItem.Text = "Time Run";
            this.timeRunToolStripMenuItem.Click += new System.EventHandler(this.timeRunToolStripMenuItem_Click);
            // 
            // clickLimitToolStripMenuItem
            // 
            this.clickLimitToolStripMenuItem.Name = "clickLimitToolStripMenuItem";
            this.clickLimitToolStripMenuItem.Size = new System.Drawing.Size(266, 46);
            this.clickLimitToolStripMenuItem.Text = "Click Limit";
            // 
            // playAgainToolStripMenuItem
            // 
            this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
            this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(168, 45);
            this.playAgainToolStripMenuItem.Text = "Play Again";
            this.playAgainToolStripMenuItem.Click += new System.EventHandler(this.playAgainToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(76, 45);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 32);
            this.label2.TabIndex = 242;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 32);
            this.label3.TabIndex = 243;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 32);
            this.label4.TabIndex = 244;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 32);
            this.label5.TabIndex = 245;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 32);
            this.label6.TabIndex = 247;
            this.label6.Text = "F";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 32);
            this.label7.TabIndex = 246;
            this.label7.Text = "E";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 999);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 32);
            this.label8.TabIndex = 251;
            this.label8.Text = "J";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 901);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 32);
            this.label9.TabIndex = 250;
            this.label9.Text = "I";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 801);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 32);
            this.label10.TabIndex = 249;
            this.label10.Text = "H";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 704);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 32);
            this.label11.TabIndex = 248;
            this.label11.Text = "G";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 1083);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 32);
            this.label12.TabIndex = 252;
            this.label12.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 1083);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 32);
            this.label13.TabIndex = 253;
            this.label13.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(356, 1083);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 32);
            this.label14.TabIndex = 254;
            this.label14.Text = "3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(673, 1083);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 32);
            this.label15.TabIndex = 257;
            this.label15.Text = "6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(567, 1083);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 32);
            this.label16.TabIndex = 256;
            this.label16.Text = "5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(465, 1083);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 32);
            this.label17.TabIndex = 255;
            this.label17.Text = "4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1088, 1083);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 32);
            this.label18.TabIndex = 261;
            this.label18.Text = "10";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(996, 1083);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 32);
            this.label19.TabIndex = 260;
            this.label19.Text = "9";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(890, 1083);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 32);
            this.label20.TabIndex = 259;
            this.label20.Text = "8";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(784, 1083);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 32);
            this.label21.TabIndex = 258;
            this.label21.Text = "7";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerL
            // 
            this.TimerL.AutoSize = true;
            this.TimerL.Location = new System.Drawing.Point(151, 1175);
            this.TimerL.Name = "TimerL";
            this.TimerL.Size = new System.Drawing.Size(95, 32);
            this.TimerL.TabIndex = 262;
            this.TimerL.Text = "Timer:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1153, 1360);
            this.Controls.Add(this.TimerL);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "BattleShip Game V 1.0";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeGameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickLimitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerL;
    }
}