namespace Opdracht2
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
            this.CBKoe = new System.Windows.Forms.CheckBox();
            this.CBSlang = new System.Windows.Forms.CheckBox();
            this.CBVarken = new System.Windows.Forms.CheckBox();
            this.BTDieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBKoe
            // 
            this.CBKoe.AutoSize = true;
            this.CBKoe.Location = new System.Drawing.Point(187, 139);
            this.CBKoe.Name = "CBKoe";
            this.CBKoe.Size = new System.Drawing.Size(53, 20);
            this.CBKoe.TabIndex = 0;
            this.CBKoe.Text = "Koe";
            this.CBKoe.UseVisualStyleBackColor = true;
            // 
            // CBSlang
            // 
            this.CBSlang.AutoSize = true;
            this.CBSlang.Location = new System.Drawing.Point(368, 139);
            this.CBSlang.Name = "CBSlang";
            this.CBSlang.Size = new System.Drawing.Size(64, 20);
            this.CBSlang.TabIndex = 1;
            this.CBSlang.Text = "Slang";
            this.CBSlang.UseVisualStyleBackColor = true;
            // 
            // CBVarken
            // 
            this.CBVarken.AutoSize = true;
            this.CBVarken.Location = new System.Drawing.Point(553, 139);
            this.CBVarken.Name = "CBVarken";
            this.CBVarken.Size = new System.Drawing.Size(72, 20);
            this.CBVarken.TabIndex = 2;
            this.CBVarken.Text = "Varken";
            this.CBVarken.UseVisualStyleBackColor = true;
            // 
            // BTDieren
            // 
            this.BTDieren.Location = new System.Drawing.Point(173, 175);
            this.BTDieren.Name = "BTDieren";
            this.BTDieren.Size = new System.Drawing.Size(452, 37);
            this.BTDieren.TabIndex = 3;
            this.BTDieren.Text = "Geluid dieren ";
            this.BTDieren.UseVisualStyleBackColor = true;
            this.BTDieren.Click += new System.EventHandler(this.BTDieren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTDieren);
            this.Controls.Add(this.CBVarken);
            this.Controls.Add(this.CBSlang);
            this.Controls.Add(this.CBKoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBKoe;
        private System.Windows.Forms.CheckBox CBSlang;
        private System.Windows.Forms.CheckBox CBVarken;
        private System.Windows.Forms.Button BTDieren;
    }
}

