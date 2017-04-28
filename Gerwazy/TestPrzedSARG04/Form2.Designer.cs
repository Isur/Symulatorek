namespace Gerwazy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailDawidLabel = new System.Windows.Forms.Label();
            this.numberDawidLabel = new System.Windows.Forms.Label();
            this.numberArturLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artur Bednarczyk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dawid Grajewski";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "bednarczykartur96@gmail.com";
            // 
            // emailDawidLabel
            // 
            this.emailDawidLabel.AutoSize = true;
            this.emailDawidLabel.Location = new System.Drawing.Point(131, 30);
            this.emailDawidLabel.Name = "emailDawidLabel";
            this.emailDawidLabel.Size = new System.Drawing.Size(116, 13);
            this.emailDawidLabel.TabIndex = 4;
            this.emailDawidLabel.Text = "dawids115@gmail.com";
            // 
            // numberDawidLabel
            // 
            this.numberDawidLabel.AutoSize = true;
            this.numberDawidLabel.Location = new System.Drawing.Point(131, 43);
            this.numberDawidLabel.Name = "numberDawidLabel";
            this.numberDawidLabel.Size = new System.Drawing.Size(93, 13);
            this.numberDawidLabel.TabIndex = 5;
            this.numberDawidLabel.Text = "kom. 570 423 547";
            // 
            // numberArturLabel
            // 
            this.numberArturLabel.AutoSize = true;
            this.numberArturLabel.Location = new System.Drawing.Point(131, 86);
            this.numberArturLabel.Name = "numberArturLabel";
            this.numberArturLabel.Size = new System.Drawing.Size(93, 13);
            this.numberArturLabel.TabIndex = 6;
            this.numberArturLabel.Text = "kom. 518 321 258";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 108);
            this.Controls.Add(this.numberArturLabel);
            this.Controls.Add(this.numberDawidLabel);
            this.Controls.Add(this.emailDawidLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "O twórcach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label emailDawidLabel;
        private System.Windows.Forms.Label numberDawidLabel;
        private System.Windows.Forms.Label numberArturLabel;
    }
}