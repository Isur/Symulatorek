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
            this.checkBox_decodeRandom = new System.Windows.Forms.CheckBox();
            this.checkBox_decodePeriodicity = new System.Windows.Forms.CheckBox();
            this.numericUpDown_decodePeriodicity = new System.Windows.Forms.NumericUpDown();
            this.groupBox_cards = new System.Windows.Forms.GroupBox();
            this.label_keyQuantity = new System.Windows.Forms.Label();
            this.label_keyLength = new System.Windows.Forms.Label();
            this.numericUpDown_keyLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.textBox_resultFileSource = new System.Windows.Forms.TextBox();
            this.label_resultFileSource = new System.Windows.Forms.Label();
            this.label_minIt = new System.Windows.Forms.Label();
            this.label_minItQuantity = new System.Windows.Forms.Label();
            this.lable_maxIt = new System.Windows.Forms.Label();
            this.label_maxItQuantity = new System.Windows.Forms.Label();
            this.label_averageIt = new System.Windows.Forms.Label();
            this.label_averageItQuantity = new System.Windows.Forms.Label();
            this.groupBox_decode = new System.Windows.Forms.GroupBox();
            this.button_resultFileSource = new System.Windows.Forms.Button();
            this.groupBox_shortStatistics = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_decodePeriodicity)).BeginInit();
            this.groupBox_cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.groupBox_decode.SuspendLayout();
            this.groupBox_shortStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            resources.ApplyResources(this.button_start, "button_start");
            this.button_start.Name = "button_start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // checkBox_decodeRandom
            // 
            resources.ApplyResources(this.checkBox_decodeRandom, "checkBox_decodeRandom");
            this.checkBox_decodeRandom.Name = "checkBox_decodeRandom";
            this.checkBox_decodeRandom.UseVisualStyleBackColor = true;
            // 
            // checkBox_decodePeriodicity
            // 
            resources.ApplyResources(this.checkBox_decodePeriodicity, "checkBox_decodePeriodicity");
            this.checkBox_decodePeriodicity.Name = "checkBox_decodePeriodicity";
            this.checkBox_decodePeriodicity.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_decodePeriodicity
            // 
            resources.ApplyResources(this.numericUpDown_decodePeriodicity, "numericUpDown_decodePeriodicity");
            this.numericUpDown_decodePeriodicity.Name = "numericUpDown_decodePeriodicity";
            // 
            // groupBox_cards
            // 
            this.groupBox_cards.Controls.Add(this.label_keyQuantity);
            this.groupBox_cards.Controls.Add(this.label_keyLength);
            this.groupBox_cards.Controls.Add(this.numericUpDown_keyLength);
            this.groupBox_cards.Controls.Add(this.numericUpDown_quantity);
            resources.ApplyResources(this.groupBox_cards, "groupBox_cards");
            this.groupBox_cards.Name = "groupBox_cards";
            this.groupBox_cards.TabStop = false;
            // 
            // label_keyQuantity
            // 
            resources.ApplyResources(this.label_keyQuantity, "label_keyQuantity");
            this.label_keyQuantity.Name = "label_keyQuantity";
            // 
            // label_keyLength
            // 
            resources.ApplyResources(this.label_keyLength, "label_keyLength");
            this.label_keyLength.Name = "label_keyLength";
            // 
            // numericUpDown_keyLength
            // 
            resources.ApplyResources(this.numericUpDown_keyLength, "numericUpDown_keyLength");
            this.numericUpDown_keyLength.Name = "numericUpDown_keyLength";
            // 
            // numericUpDown_quantity
            // 
            resources.ApplyResources(this.numericUpDown_quantity, "numericUpDown_quantity");
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            // 
            // textBox_resultFileSource
            // 
            resources.ApplyResources(this.textBox_resultFileSource, "textBox_resultFileSource");
            this.textBox_resultFileSource.Name = "textBox_resultFileSource";
            // 
            // label_resultFileSource
            // 
            resources.ApplyResources(this.label_resultFileSource, "label_resultFileSource");
            this.label_resultFileSource.Name = "label_resultFileSource";
            // 
            // label_minIt
            // 
            resources.ApplyResources(this.label_minIt, "label_minIt");
            this.label_minIt.Name = "label_minIt";
            // 
            // label_minItQuantity
            // 
            resources.ApplyResources(this.label_minItQuantity, "label_minItQuantity");
            this.label_minItQuantity.Name = "label_minItQuantity";
            // 
            // lable_maxIt
            // 
            resources.ApplyResources(this.lable_maxIt, "lable_maxIt");
            this.lable_maxIt.Name = "lable_maxIt";
            // 
            // label_maxItQuantity
            // 
            resources.ApplyResources(this.label_maxItQuantity, "label_maxItQuantity");
            this.label_maxItQuantity.Name = "label_maxItQuantity";
            // 
            // label_averageIt
            // 
            resources.ApplyResources(this.label_averageIt, "label_averageIt");
            this.label_averageIt.Name = "label_averageIt";
            // 
            // label_averageItQuantity
            // 
            resources.ApplyResources(this.label_averageItQuantity, "label_averageItQuantity");
            this.label_averageItQuantity.Name = "label_averageItQuantity";
            // 
            // groupBox_decode
            // 
            this.groupBox_decode.Controls.Add(this.numericUpDown_decodePeriodicity);
            this.groupBox_decode.Controls.Add(this.checkBox_decodePeriodicity);
            this.groupBox_decode.Controls.Add(this.checkBox_decodeRandom);
            resources.ApplyResources(this.groupBox_decode, "groupBox_decode");
            this.groupBox_decode.Name = "groupBox_decode";
            this.groupBox_decode.TabStop = false;
            // 
            // button_resultFileSource
            // 
            resources.ApplyResources(this.button_resultFileSource, "button_resultFileSource");
            this.button_resultFileSource.Name = "button_resultFileSource";
            this.button_resultFileSource.UseVisualStyleBackColor = true;
            // 
            // groupBox_shortStatistics
            // 
            this.groupBox_shortStatistics.Controls.Add(this.lable_maxIt);
            this.groupBox_shortStatistics.Controls.Add(this.label_minIt);
            this.groupBox_shortStatistics.Controls.Add(this.label_minItQuantity);
            this.groupBox_shortStatistics.Controls.Add(this.label_averageItQuantity);
            this.groupBox_shortStatistics.Controls.Add(this.label_maxItQuantity);
            this.groupBox_shortStatistics.Controls.Add(this.label_averageIt);
            resources.ApplyResources(this.groupBox_shortStatistics, "groupBox_shortStatistics");
            this.groupBox_shortStatistics.Name = "groupBox_shortStatistics";
            this.groupBox_shortStatistics.TabStop = false;
            this.groupBox_shortStatistics.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_shortStatistics);
            this.Controls.Add(this.button_resultFileSource);
            this.Controls.Add(this.groupBox_decode);
            this.Controls.Add(this.label_resultFileSource);
            this.Controls.Add(this.textBox_resultFileSource);
            this.Controls.Add(this.groupBox_cards);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_decodePeriodicity)).EndInit();
            this.groupBox_cards.ResumeLayout(false);
            this.groupBox_cards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.groupBox_decode.ResumeLayout(false);
            this.groupBox_decode.PerformLayout();
            this.groupBox_shortStatistics.ResumeLayout(false);
            this.groupBox_shortStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.CheckBox checkBox_decodeRandom;
        private System.Windows.Forms.CheckBox checkBox_decodePeriodicity;
        private System.Windows.Forms.NumericUpDown numericUpDown_decodePeriodicity;
        private System.Windows.Forms.GroupBox groupBox_cards;
        private System.Windows.Forms.NumericUpDown numericUpDown_keyLength;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.TextBox textBox_resultFileSource;
        private System.Windows.Forms.Label label_resultFileSource;
        private System.Windows.Forms.Label label_minIt;
        private System.Windows.Forms.Label label_minItQuantity;
        private System.Windows.Forms.Label lable_maxIt;
        private System.Windows.Forms.Label label_maxItQuantity;
        private System.Windows.Forms.Label label_averageIt;
        private System.Windows.Forms.Label label_averageItQuantity;
        private System.Windows.Forms.GroupBox groupBox_decode;
        private System.Windows.Forms.Label label_keyQuantity;
        private System.Windows.Forms.Label label_keyLength;
        private System.Windows.Forms.Button button_resultFileSource;
        private System.Windows.Forms.GroupBox groupBox_shortStatistics;
    }
}

