namespace House
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
            this.description = new System.Windows.Forms.TextBox();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThrughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 9);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(326, 124);
            this.description.TabIndex = 0;
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(101, 141);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(237, 21);
            this.exits.TabIndex = 1;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(12, 139);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(83, 23);
            this.goHere.TabIndex = 2;
            this.goHere.Text = "Go here:";
            this.goHere.UseVisualStyleBackColor = true;
            // 
            // goThrughTheDoor
            // 
            this.goThrughTheDoor.Location = new System.Drawing.Point(12, 168);
            this.goThrughTheDoor.Name = "goThrughTheDoor";
            this.goThrughTheDoor.Size = new System.Drawing.Size(326, 23);
            this.goThrughTheDoor.TabIndex = 3;
            this.goThrughTheDoor.Text = "Go through the door";
            this.goThrughTheDoor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 202);
            this.Controls.Add(this.goThrughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThrughTheDoor;
    }
}

