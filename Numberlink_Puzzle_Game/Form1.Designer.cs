
namespace Numberlink_Puzzle_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupGameSpace = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericMistake = new System.Windows.Forms.NumericUpDown();
            this.BtnVeryHard = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.BtnMedium = new System.Windows.Forms.Button();
            this.BtnEasy = new System.Windows.Forms.Button();
            this.BtnVeryEasy = new System.Windows.Forms.Button();
            this.LblMinute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblVertical = new System.Windows.Forms.Label();
            this.TxtVertical = new System.Windows.Forms.TextBox();
            this.LblHorizontal = new System.Windows.Forms.Label();
            this.TxtHorizontal = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMistake)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupGameSpace
            // 
            this.GroupGameSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupGameSpace.Location = new System.Drawing.Point(0, 0);
            this.GroupGameSpace.Name = "GroupGameSpace";
            this.GroupGameSpace.Size = new System.Drawing.Size(794, 720);
            this.GroupGameSpace.TabIndex = 0;
            this.GroupGameSpace.TabStop = false;
            this.GroupGameSpace.Text = "Game Space";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NumericMistake);
            this.groupBox2.Controls.Add(this.BtnVeryHard);
            this.groupBox2.Controls.Add(this.BtnHard);
            this.groupBox2.Controls.Add(this.BtnMedium);
            this.groupBox2.Controls.Add(this.BtnEasy);
            this.groupBox2.Controls.Add(this.BtnVeryEasy);
            this.groupBox2.Controls.Add(this.LblMinute);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LblSecond);
            this.groupBox2.Controls.Add(this.LblTime);
            this.groupBox2.Controls.Add(this.LblVertical);
            this.groupBox2.Controls.Add(this.TxtVertical);
            this.groupBox2.Controls.Add(this.LblHorizontal);
            this.groupBox2.Controls.Add(this.TxtHorizontal);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.BtnStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(794, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 720);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mistake:";
            // 
            // NumericMistake
            // 
            this.NumericMistake.Enabled = false;
            this.NumericMistake.Location = new System.Drawing.Point(100, 72);
            this.NumericMistake.Name = "NumericMistake";
            this.NumericMistake.Size = new System.Drawing.Size(150, 27);
            this.NumericMistake.TabIndex = 15;
            // 
            // BtnVeryHard
            // 
            this.BtnVeryHard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVeryHard.Location = new System.Drawing.Point(6, 388);
            this.BtnVeryHard.Name = "BtnVeryHard";
            this.BtnVeryHard.Size = new System.Drawing.Size(244, 57);
            this.BtnVeryHard.TabIndex = 14;
            this.BtnVeryHard.Text = "Very Hard";
            this.BtnVeryHard.UseVisualStyleBackColor = true;
            this.BtnVeryHard.Click += new System.EventHandler(this.BtnVeryHard_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHard.Location = new System.Drawing.Point(6, 325);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(244, 57);
            this.BtnHard.TabIndex = 13;
            this.BtnHard.Text = "Hard";
            this.BtnHard.UseVisualStyleBackColor = true;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // BtnMedium
            // 
            this.BtnMedium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMedium.Location = new System.Drawing.Point(6, 262);
            this.BtnMedium.Name = "BtnMedium";
            this.BtnMedium.Size = new System.Drawing.Size(244, 57);
            this.BtnMedium.TabIndex = 12;
            this.BtnMedium.Text = "Medium";
            this.BtnMedium.UseVisualStyleBackColor = true;
            this.BtnMedium.Click += new System.EventHandler(this.BtnMedium_Click);
            // 
            // BtnEasy
            // 
            this.BtnEasy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEasy.Location = new System.Drawing.Point(6, 199);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(244, 57);
            this.BtnEasy.TabIndex = 11;
            this.BtnEasy.Text = "Easy";
            this.BtnEasy.UseVisualStyleBackColor = true;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            // 
            // BtnVeryEasy
            // 
            this.BtnVeryEasy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVeryEasy.Location = new System.Drawing.Point(6, 136);
            this.BtnVeryEasy.Name = "BtnVeryEasy";
            this.BtnVeryEasy.Size = new System.Drawing.Size(244, 57);
            this.BtnVeryEasy.TabIndex = 10;
            this.BtnVeryEasy.Text = "Very Easy";
            this.BtnVeryEasy.UseVisualStyleBackColor = true;
            this.BtnVeryEasy.Click += new System.EventHandler(this.BtnVeryEasy_Click);
            // 
            // LblMinute
            // 
            this.LblMinute.AutoSize = true;
            this.LblMinute.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMinute.Location = new System.Drawing.Point(92, 23);
            this.LblMinute.Name = "LblMinute";
            this.LblMinute.Size = new System.Drawing.Size(32, 25);
            this.LblMinute.TabIndex = 9;
            this.LblMinute.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSecond.Location = new System.Drawing.Point(144, 23);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(32, 25);
            this.LblSecond.TabIndex = 7;
            this.LblSecond.Text = "00";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTime.Location = new System.Drawing.Point(27, 23);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(59, 25);
            this.LblTime.TabIndex = 6;
            this.LblTime.Text = "Time:";
            // 
            // LblVertical
            // 
            this.LblVertical.AutoSize = true;
            this.LblVertical.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVertical.Location = new System.Drawing.Point(27, 553);
            this.LblVertical.Name = "LblVertical";
            this.LblVertical.Size = new System.Drawing.Size(82, 25);
            this.LblVertical.TabIndex = 5;
            this.LblVertical.Text = "Vertical:";
            // 
            // TxtVertical
            // 
            this.TxtVertical.Enabled = false;
            this.TxtVertical.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtVertical.Location = new System.Drawing.Point(115, 550);
            this.TxtVertical.Name = "TxtVertical";
            this.TxtVertical.Size = new System.Drawing.Size(135, 31);
            this.TxtVertical.TabIndex = 4;
            // 
            // LblHorizontal
            // 
            this.LblHorizontal.AutoSize = true;
            this.LblHorizontal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHorizontal.Location = new System.Drawing.Point(2, 513);
            this.LblHorizontal.Name = "LblHorizontal";
            this.LblHorizontal.Size = new System.Drawing.Size(107, 25);
            this.LblHorizontal.TabIndex = 3;
            this.LblHorizontal.Text = "Horizontal:";
            // 
            // TxtHorizontal
            // 
            this.TxtHorizontal.Enabled = false;
            this.TxtHorizontal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtHorizontal.Location = new System.Drawing.Point(115, 510);
            this.TxtHorizontal.Name = "TxtHorizontal";
            this.TxtHorizontal.Size = new System.Drawing.Size(135, 31);
            this.TxtHorizontal.TabIndex = 2;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.Location = new System.Drawing.Point(71, 657);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(179, 51);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(71, 600);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(179, 51);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 720);
            this.Controls.Add(this.GroupGameSpace);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMistake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupGameSpace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblVertical;
        private System.Windows.Forms.Label LblHorizontal;
        private System.Windows.Forms.TextBox TxtHorizontal;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Label LblMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVeryHard;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Button BtnMedium;
        private System.Windows.Forms.Button BtnEasy;
        private System.Windows.Forms.Button BtnVeryEasy;
        private System.Windows.Forms.TextBox TxtVertical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericMistake;
    }
}

