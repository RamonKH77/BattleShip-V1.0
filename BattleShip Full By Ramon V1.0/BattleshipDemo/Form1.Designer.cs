namespace BattleshipDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Type here your username";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 36);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Time Run Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 49);
            this.menuStrip1.TabIndex = 242;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
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
            // 
            // changeGameModeToolStripMenuItem
            // 
            this.changeGameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeRunToolStripMenuItem,
            this.clickLimitToolStripMenuItem,
            this.freeModeToolStripMenuItem});
            this.changeGameModeToolStripMenuItem.Name = "changeGameModeToolStripMenuItem";
            this.changeGameModeToolStripMenuItem.Size = new System.Drawing.Size(481, 46);
            this.changeGameModeToolStripMenuItem.Text = "Change Game Mode";
            // 
            // timeRunToolStripMenuItem
            // 
            this.timeRunToolStripMenuItem.Name = "timeRunToolStripMenuItem";
            this.timeRunToolStripMenuItem.Size = new System.Drawing.Size(276, 46);
            this.timeRunToolStripMenuItem.Text = "Time Run";
            // 
            // clickLimitToolStripMenuItem
            // 
            this.clickLimitToolStripMenuItem.Name = "clickLimitToolStripMenuItem";
            this.clickLimitToolStripMenuItem.Size = new System.Drawing.Size(276, 46);
            this.clickLimitToolStripMenuItem.Text = "Click Limit";
            // 
            // freeModeToolStripMenuItem
            // 
            this.freeModeToolStripMenuItem.Name = "freeModeToolStripMenuItem";
            this.freeModeToolStripMenuItem.Size = new System.Drawing.Size(276, 46);
            this.freeModeToolStripMenuItem.Text = "Free Mode";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(76, 45);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(653, 341);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BattleShip Game V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

