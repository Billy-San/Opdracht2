namespace Oefening2
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
            this.Cow = new System.Windows.Forms.CheckBox();
            this.Pig = new System.Windows.Forms.CheckBox();
            this.Snake = new System.Windows.Forms.CheckBox();
            this.Sound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cow
            // 
            this.Cow.AutoSize = true;
            this.Cow.Location = new System.Drawing.Point(222, 142);
            this.Cow.Name = "Cow";
            this.Cow.Size = new System.Drawing.Size(73, 29);
            this.Cow.TabIndex = 0;
            this.Cow.Text = "Cow";
            this.Cow.UseVisualStyleBackColor = true;
            // 
            // Pig
            // 
            this.Pig.AutoSize = true;
            this.Pig.Location = new System.Drawing.Point(222, 189);
            this.Pig.Name = "Pig";
            this.Pig.Size = new System.Drawing.Size(63, 29);
            this.Pig.TabIndex = 1;
            this.Pig.Text = "Pig";
            this.Pig.UseVisualStyleBackColor = true;
            // 
            // Snake
            // 
            this.Snake.AutoSize = true;
            this.Snake.Location = new System.Drawing.Point(222, 238);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(85, 29);
            this.Snake.TabIndex = 2;
            this.Snake.Text = "Snake";
            this.Snake.UseVisualStyleBackColor = true;
            // 
            // Sound
            // 
            this.Sound.Location = new System.Drawing.Point(222, 295);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(112, 34);
            this.Sound.TabIndex = 3;
            this.Sound.Text = "Laat horen";
            this.Sound.UseVisualStyleBackColor = true;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.Snake);
            this.Controls.Add(this.Pig);
            this.Controls.Add(this.Cow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Cow;
        private CheckBox Pig;
        private CheckBox Snake;
        private Button Sound;
    }
}