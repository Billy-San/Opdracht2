namespace Oefening3
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
            this.USD = new System.Windows.Forms.Label();
            this.BritishPound = new System.Windows.Forms.Label();
            this.Euro = new System.Windows.Forms.Label();
            this.JapanseYen = new System.Windows.Forms.Label();
            this.IndiaanseRupees = new System.Windows.Forms.Label();
            this.ZwitserseFranken = new System.Windows.Forms.Label();
            this.tb_USD = new System.Windows.Forms.TextBox();
            this.tb_BP = new System.Windows.Forms.TextBox();
            this.tb_EURO = new System.Windows.Forms.TextBox();
            this.tb_JY = new System.Windows.Forms.TextBox();
            this.tb_IRUPEES = new System.Windows.Forms.TextBox();
            this.tb_ZFRANK = new System.Windows.Forms.TextBox();
            this.Convertor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USD
            // 
            this.USD.AutoSize = true;
            this.USD.Location = new System.Drawing.Point(84, 22);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(47, 25);
            this.USD.TabIndex = 0;
            this.USD.Text = "USD";
            // 
            // BritishPound
            // 
            this.BritishPound.AutoSize = true;
            this.BritishPound.Location = new System.Drawing.Point(84, 79);
            this.BritishPound.Name = "BritishPound";
            this.BritishPound.Size = new System.Drawing.Size(124, 25);
            this.BritishPound.TabIndex = 1;
            this.BritishPound.Text = "British Pounds";
            // 
            // Euro
            // 
            this.Euro.AutoSize = true;
            this.Euro.Location = new System.Drawing.Point(84, 132);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(48, 25);
            this.Euro.TabIndex = 2;
            this.Euro.Text = "Euro";
            // 
            // JapanseYen
            // 
            this.JapanseYen.AutoSize = true;
            this.JapanseYen.Location = new System.Drawing.Point(84, 191);
            this.JapanseYen.Name = "JapanseYen";
            this.JapanseYen.Size = new System.Drawing.Size(106, 25);
            this.JapanseYen.TabIndex = 3;
            this.JapanseYen.Text = "Japanse Yen";
            // 
            // IndiaanseRupees
            // 
            this.IndiaanseRupees.AutoSize = true;
            this.IndiaanseRupees.Location = new System.Drawing.Point(84, 244);
            this.IndiaanseRupees.Name = "IndiaanseRupees";
            this.IndiaanseRupees.Size = new System.Drawing.Size(150, 25);
            this.IndiaanseRupees.TabIndex = 4;
            this.IndiaanseRupees.Text = "Indiaanse Rupees";
            // 
            // ZwitserseFranken
            // 
            this.ZwitserseFranken.AutoSize = true;
            this.ZwitserseFranken.Location = new System.Drawing.Point(84, 294);
            this.ZwitserseFranken.Name = "ZwitserseFranken";
            this.ZwitserseFranken.Size = new System.Drawing.Size(152, 25);
            this.ZwitserseFranken.TabIndex = 5;
            this.ZwitserseFranken.Text = "Zwitserse Franken";
            // 
            // tb_USD
            // 
            this.tb_USD.Location = new System.Drawing.Point(240, 22);
            this.tb_USD.Name = "tb_USD";
            this.tb_USD.Size = new System.Drawing.Size(150, 31);
            this.tb_USD.TabIndex = 6;
            // 
            // tb_BP
            // 
            this.tb_BP.Location = new System.Drawing.Point(240, 79);
            this.tb_BP.Name = "tb_BP";
            this.tb_BP.Size = new System.Drawing.Size(150, 31);
            this.tb_BP.TabIndex = 7;
            // 
            // tb_EURO
            // 
            this.tb_EURO.Location = new System.Drawing.Point(240, 126);
            this.tb_EURO.Name = "tb_EURO";
            this.tb_EURO.Size = new System.Drawing.Size(150, 31);
            this.tb_EURO.TabIndex = 8;
            // 
            // tb_JY
            // 
            this.tb_JY.Location = new System.Drawing.Point(240, 188);
            this.tb_JY.Name = "tb_JY";
            this.tb_JY.Size = new System.Drawing.Size(150, 31);
            this.tb_JY.TabIndex = 9;
            // 
            // tb_IRUPEES
            // 
            this.tb_IRUPEES.Location = new System.Drawing.Point(240, 244);
            this.tb_IRUPEES.Name = "tb_IRUPEES";
            this.tb_IRUPEES.Size = new System.Drawing.Size(150, 31);
            this.tb_IRUPEES.TabIndex = 10;
            // 
            // tb_ZFRANK
            // 
            this.tb_ZFRANK.Location = new System.Drawing.Point(240, 291);
            this.tb_ZFRANK.Name = "tb_ZFRANK";
            this.tb_ZFRANK.Size = new System.Drawing.Size(150, 31);
            this.tb_ZFRANK.TabIndex = 11;
            // 
            // Convertor
            // 
            this.Convertor.Location = new System.Drawing.Point(240, 356);
            this.Convertor.Name = "Convertor";
            this.Convertor.Size = new System.Drawing.Size(150, 39);
            this.Convertor.TabIndex = 12;
            this.Convertor.Text = "Convert";
            this.Convertor.UseVisualStyleBackColor = true;
            this.Convertor.Click += new System.EventHandler(this.Convertor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Convertor);
            this.Controls.Add(this.tb_ZFRANK);
            this.Controls.Add(this.tb_IRUPEES);
            this.Controls.Add(this.tb_JY);
            this.Controls.Add(this.tb_EURO);
            this.Controls.Add(this.tb_BP);
            this.Controls.Add(this.tb_USD);
            this.Controls.Add(this.ZwitserseFranken);
            this.Controls.Add(this.IndiaanseRupees);
            this.Controls.Add(this.JapanseYen);
            this.Controls.Add(this.Euro);
            this.Controls.Add(this.BritishPound);
            this.Controls.Add(this.USD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label USD;
        private Label BritishPound;
        private Label Euro;
        private Label JapanseYen;
        private Label IndiaanseRupees;
        private Label ZwitserseFranken;
        private TextBox tb_USD;
        private TextBox tb_BP;
        private TextBox tb_EURO;
        private TextBox tb_JY;
        private TextBox tb_IRUPEES;
        private TextBox tb_ZFRANK;
        private Button Convertor;
    }
}