namespace oef3
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
            this.Euro = new System.Windows.Forms.TextBox();
            this.Dollar = new System.Windows.Forms.MaskedTextBox();
            this.Yen = new System.Windows.Forms.TextBox();
            this.Rupees = new System.Windows.Forms.TextBox();
            this.Pounds = new System.Windows.Forms.TextBox();
            this.Franken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Euro
            // 
            this.Euro.Location = new System.Drawing.Point(98, 160);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(100, 22);
            this.Euro.TabIndex = 0;
            // 
            // Dollar
            // 
            this.Dollar.Location = new System.Drawing.Point(315, 160);
            this.Dollar.Name = "Dollar";
            this.Dollar.Size = new System.Drawing.Size(100, 22);
            this.Dollar.TabIndex = 1;
            // 
            // Yen
            // 
            this.Yen.Location = new System.Drawing.Point(315, 278);
            this.Yen.Name = "Yen";
            this.Yen.Size = new System.Drawing.Size(100, 22);
            this.Yen.TabIndex = 2;
            // 
            // Rupees
            // 
            this.Rupees.Location = new System.Drawing.Point(315, 332);
            this.Rupees.Name = "Rupees";
            this.Rupees.Size = new System.Drawing.Size(100, 22);
            this.Rupees.TabIndex = 3;
            // 
            // Pounds
            // 
            this.Pounds.Location = new System.Drawing.Point(315, 220);
            this.Pounds.Name = "Pounds";
            this.Pounds.Size = new System.Drawing.Size(100, 22);
            this.Pounds.TabIndex = 4;
            // 
            // Franken
            // 
            this.Franken.Location = new System.Drawing.Point(315, 387);
            this.Franken.Name = "Franken";
            this.Franken.Size = new System.Drawing.Size(100, 22);
            this.Franken.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zwitserse Franken";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Indiaase Rupees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Japanse Yen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "British Pounds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "US Dollars";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "wisselkoers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Franken);
            this.Controls.Add(this.Pounds);
            this.Controls.Add(this.Rupees);
            this.Controls.Add(this.Yen);
            this.Controls.Add(this.Dollar);
            this.Controls.Add(this.Euro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Euro;
        private System.Windows.Forms.MaskedTextBox Dollar;
        private System.Windows.Forms.TextBox Yen;
        private System.Windows.Forms.TextBox Rupees;
        private System.Windows.Forms.TextBox Pounds;
        private System.Windows.Forms.TextBox Franken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

