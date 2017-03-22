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
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox_cards = new System.Windows.Forms.GroupBox();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_keyLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox_cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyLength)).BeginInit();
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
            // numericUpDown
            // 
            resources.ApplyResources(this.numericUpDown, "numericUpDown");
            this.numericUpDown.Name = "numericUpDown";
            // 
            // groupBox_cards
            // 
            this.groupBox_cards.Controls.Add(this.numericUpDown_keyLength);
            this.groupBox_cards.Controls.Add(this.numericUpDown_quantity);
            resources.ApplyResources(this.groupBox_cards, "groupBox_cards");
            this.groupBox_cards.Name = "groupBox_cards";
            this.groupBox_cards.TabStop = false;
            // 
            // numericUpDown_quantity
            // 
            resources.ApplyResources(this.numericUpDown_quantity, "numericUpDown_quantity");
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            // 
            // numericUpDown_keyLength
            // 
            resources.ApplyResources(this.numericUpDown_keyLength, "numericUpDown_keyLength");
            this.numericUpDown_keyLength.Name = "numericUpDown_keyLength";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_cards);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.checkBox_periodicity);
            this.Controls.Add(this.checkBox_random);
            this.Controls.Add(this.label_decode);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox_cards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_decode;
        private System.Windows.Forms.CheckBox checkBox_random;
        private System.Windows.Forms.CheckBox checkBox_periodicity;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.GroupBox groupBox_cards;
        private System.Windows.Forms.NumericUpDown numericUpDown_keyLength;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
    }
}

