namespace BreakfastForLumberjacks
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
            this.label1 = new System.Windows.Forms.Label();
            this.LumberjackName = new System.Windows.Forms.TextBox();
            this.AddALumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BreakfastLine = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HowMany = new System.Windows.Forms.NumericUpDown();
            this.CrispyRb = new System.Windows.Forms.RadioButton();
            this.SoggyRb = new System.Windows.Forms.RadioButton();
            this.BrownedRb = new System.Windows.Forms.RadioButton();
            this.BananaRb = new System.Windows.Forms.RadioButton();
            this.AddAFlapjack = new System.Windows.Forms.Button();
            this.nextLumberkack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HowMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // LumberjackName
            // 
            this.LumberjackName.Location = new System.Drawing.Point(109, 6);
            this.LumberjackName.Name = "LumberjackName";
            this.LumberjackName.Size = new System.Drawing.Size(130, 20);
            this.LumberjackName.TabIndex = 1;
            // 
            // AddALumberjack
            // 
            this.AddALumberjack.Location = new System.Drawing.Point(15, 32);
            this.AddALumberjack.Name = "AddALumberjack";
            this.AddALumberjack.Size = new System.Drawing.Size(224, 23);
            this.AddALumberjack.TabIndex = 2;
            this.AddALumberjack.Text = "Add lumberjack";
            this.AddALumberjack.UseVisualStyleBackColor = true;
            this.AddALumberjack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breakfast line";
            // 
            // BreakfastLine
            // 
            this.BreakfastLine.FormattingEnabled = true;
            this.BreakfastLine.Location = new System.Drawing.Point(13, 79);
            this.BreakfastLine.Name = "BreakfastLine";
            this.BreakfastLine.Size = new System.Drawing.Size(120, 251);
            this.BreakfastLine.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nextLumberkack);
            this.groupBox1.Controls.Add(this.AddAFlapjack);
            this.groupBox1.Controls.Add(this.BananaRb);
            this.groupBox1.Controls.Add(this.BrownedRb);
            this.groupBox1.Controls.Add(this.SoggyRb);
            this.groupBox1.Controls.Add(this.CrispyRb);
            this.groupBox1.Controls.Add(this.HowMany);
            this.groupBox1.Location = new System.Drawing.Point(140, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a lumberjack";
            // 
            // HowMany
            // 
            this.HowMany.Location = new System.Drawing.Point(6, 19);
            this.HowMany.Name = "HowMany";
            this.HowMany.Size = new System.Drawing.Size(63, 20);
            this.HowMany.TabIndex = 0;
            // 
            // CrispyRb
            // 
            this.CrispyRb.AutoSize = true;
            this.CrispyRb.Location = new System.Drawing.Point(6, 46);
            this.CrispyRb.Name = "CrispyRb";
            this.CrispyRb.Size = new System.Drawing.Size(53, 17);
            this.CrispyRb.TabIndex = 1;
            this.CrispyRb.TabStop = true;
            this.CrispyRb.Text = "Cripsy";
            this.CrispyRb.UseVisualStyleBackColor = true;
            // 
            // SoggyRb
            // 
            this.SoggyRb.AutoSize = true;
            this.SoggyRb.Location = new System.Drawing.Point(7, 70);
            this.SoggyRb.Name = "SoggyRb";
            this.SoggyRb.Size = new System.Drawing.Size(55, 17);
            this.SoggyRb.TabIndex = 2;
            this.SoggyRb.TabStop = true;
            this.SoggyRb.Text = "Soggy";
            this.SoggyRb.UseVisualStyleBackColor = true;
            // 
            // BrownedRb
            // 
            this.BrownedRb.AutoSize = true;
            this.BrownedRb.Location = new System.Drawing.Point(7, 94);
            this.BrownedRb.Name = "BrownedRb";
            this.BrownedRb.Size = new System.Drawing.Size(67, 17);
            this.BrownedRb.TabIndex = 3;
            this.BrownedRb.TabStop = true;
            this.BrownedRb.Text = "Browned";
            this.BrownedRb.UseVisualStyleBackColor = true;
            // 
            // BananaRb
            // 
            this.BananaRb.AutoSize = true;
            this.BananaRb.Location = new System.Drawing.Point(6, 118);
            this.BananaRb.Name = "BananaRb";
            this.BananaRb.Size = new System.Drawing.Size(62, 17);
            this.BananaRb.TabIndex = 4;
            this.BananaRb.TabStop = true;
            this.BananaRb.Text = "Banana";
            this.BananaRb.UseVisualStyleBackColor = true;
            // 
            // AddAFlapjack
            // 
            this.AddAFlapjack.Location = new System.Drawing.Point(7, 142);
            this.AddAFlapjack.Name = "AddAFlapjack";
            this.AddAFlapjack.Size = new System.Drawing.Size(128, 23);
            this.AddAFlapjack.TabIndex = 5;
            this.AddAFlapjack.Text = "Add a flapjacks";
            this.AddAFlapjack.UseVisualStyleBackColor = true;
            this.AddAFlapjack.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextLumberkack
            // 
            this.nextLumberkack.Location = new System.Drawing.Point(7, 224);
            this.nextLumberkack.Name = "nextLumberkack";
            this.nextLumberkack.Size = new System.Drawing.Size(128, 23);
            this.nextLumberkack.TabIndex = 7;
            this.nextLumberkack.Text = "Next lumberjack";
            this.nextLumberkack.UseVisualStyleBackColor = true;
            this.nextLumberkack.Click += new System.EventHandler(this.nextLumberkack_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 49);
            this.label3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BreakfastLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddALumberjack);
            this.Controls.Add(this.LumberjackName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HowMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LumberjackName;
        private System.Windows.Forms.Button AddALumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox BreakfastLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddAFlapjack;
        private System.Windows.Forms.RadioButton BananaRb;
        private System.Windows.Forms.RadioButton BrownedRb;
        private System.Windows.Forms.RadioButton SoggyRb;
        private System.Windows.Forms.RadioButton CrispyRb;
        private System.Windows.Forms.NumericUpDown HowMany;
        private System.Windows.Forms.Button nextLumberkack;
        private System.Windows.Forms.Label label3;
    }
}

