namespace Gerwazy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.label_decode = new System.Windows.Forms.Label();
            this.checkBox_random = new System.Windows.Forms.CheckBox();
            this.checkBox_periodicity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_start
            // 
            resources.ApplyResources(this.button_start, "button_start");
            this.button_start.Name = "button_start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_decode
            // 
            resources.ApplyResources(this.label_decode, "label_decode");
            this.label_decode.Name = "label_decode";
            // 
            // checkBox_random
            // 
            resources.ApplyResources(this.checkBox_random, "checkBox_random");
            this.checkBox_random.Name = "checkBox_random";
            this.checkBox_random.UseVisualStyleBackColor = true;
            // 
            // checkBox_periodicity
            // 
            resources.ApplyResources(this.checkBox_periodicity, "checkBox_periodicity");
            this.checkBox_periodicity.Name = "checkBox_periodicity";
            this.checkBox_periodicity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_periodicity);
            this.Controls.Add(this.checkBox_random);
            this.Controls.Add(this.label_decode);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_decode;
        private System.Windows.Forms.CheckBox checkBox_random;
        private System.Windows.Forms.CheckBox checkBox_periodicity;
    }
}

