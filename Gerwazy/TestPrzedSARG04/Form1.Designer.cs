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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_cards = new System.Windows.Forms.GroupBox();
            this.label_oneKey = new System.Windows.Forms.Label();
            this.numericUpDown_oneKey = new System.Windows.Forms.NumericUpDown();
            this.label_keyQuantity = new System.Windows.Forms.Label();
            this.label_keyLength = new System.Windows.Forms.Label();
            this.numericUpDown_keyQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_keyLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox_decode = new System.Windows.Forms.GroupBox();
            this.checkBox_oneKey = new System.Windows.Forms.CheckBox();
            this.numericUpDown_periodicitiDecode = new System.Windows.Forms.NumericUpDown();
            this.checkBox_periodicityDecode = new System.Windows.Forms.CheckBox();
            this.checkBox_randomDecode = new System.Windows.Forms.CheckBox();
            this.groupBox_shortResults = new System.Windows.Forms.GroupBox();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_executionTime = new System.Windows.Forms.Label();
            this.label_averageIt = new System.Windows.Forms.Label();
            this.label_maxIt = new System.Windows.Forms.Label();
            this.label_minIt = new System.Windows.Forms.Label();
            this.label_averageItQuantity = new System.Windows.Forms.Label();
            this.label_maxItQuantity = new System.Windows.Forms.Label();
            this.label_minItQuantity = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_resultFileSource = new System.Windows.Forms.TextBox();
            this.button_resultFileSource = new System.Windows.Forms.Button();
            this.label_resultFileSource = new System.Windows.Forms.Label();
            this.progressBar_decode = new System.Windows.Forms.ProgressBar();
            this.decodingThreadTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_oneKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyLength)).BeginInit();
            this.groupBox_decode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_periodicitiDecode)).BeginInit();
            this.groupBox_shortResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_cards
            // 
            this.groupBox_cards.Controls.Add(this.label_oneKey);
            this.groupBox_cards.Controls.Add(this.numericUpDown_oneKey);
            this.groupBox_cards.Controls.Add(this.label_keyQuantity);
            this.groupBox_cards.Controls.Add(this.label_keyLength);
            this.groupBox_cards.Controls.Add(this.numericUpDown_keyQuantity);
            this.groupBox_cards.Controls.Add(this.numericUpDown_keyLength);
            this.groupBox_cards.Location = new System.Drawing.Point(12, 12);
            this.groupBox_cards.Name = "groupBox_cards";
            this.groupBox_cards.Size = new System.Drawing.Size(271, 115);
            this.groupBox_cards.TabIndex = 0;
            this.groupBox_cards.TabStop = false;
            this.groupBox_cards.Text = "Karty";
            // 
            // label_oneKey
            // 
            this.label_oneKey.AutoSize = true;
            this.label_oneKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_oneKey.Location = new System.Drawing.Point(150, 80);
            this.label_oneKey.Name = "label_oneKey";
            this.label_oneKey.Size = new System.Drawing.Size(62, 13);
            this.label_oneKey.TabIndex = 5;
            this.label_oneKey.Text = "Ilość iteracji";
            // 
            // numericUpDown_oneKey
            // 
            this.numericUpDown_oneKey.Location = new System.Drawing.Point(20, 80);
            this.numericUpDown_oneKey.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_oneKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_oneKey.Name = "numericUpDown_oneKey";
            this.numericUpDown_oneKey.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_oneKey.TabIndex = 4;
            this.numericUpDown_oneKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_keyQuantity
            // 
            this.label_keyQuantity.AutoSize = true;
            this.label_keyQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_keyQuantity.Location = new System.Drawing.Point(150, 50);
            this.label_keyQuantity.Name = "label_keyQuantity";
            this.label_keyQuantity.Size = new System.Drawing.Size(62, 13);
            this.label_keyQuantity.TabIndex = 3;
            this.label_keyQuantity.Text = "Ilość kluczy";
            // 
            // label_keyLength
            // 
            this.label_keyLength.AutoSize = true;
            this.label_keyLength.ForeColor = System.Drawing.Color.Black;
            this.label_keyLength.Location = new System.Drawing.Point(150, 20);
            this.label_keyLength.Name = "label_keyLength";
            this.label_keyLength.Size = new System.Drawing.Size(82, 13);
            this.label_keyLength.TabIndex = 2;
            this.label_keyLength.Text = "Długość klucza";
            // 
            // numericUpDown_keyQuantity
            // 
            this.numericUpDown_keyQuantity.Location = new System.Drawing.Point(20, 50);
            this.numericUpDown_keyQuantity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_keyQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_keyQuantity.Name = "numericUpDown_keyQuantity";
            this.numericUpDown_keyQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_keyQuantity.TabIndex = 1;
            this.numericUpDown_keyQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_keyLength
            // 
            this.numericUpDown_keyLength.Location = new System.Drawing.Point(20, 20);
            this.numericUpDown_keyLength.Maximum = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.numericUpDown_keyLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_keyLength.Name = "numericUpDown_keyLength";
            this.numericUpDown_keyLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_keyLength.TabIndex = 0;
            this.numericUpDown_keyLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_keyLength.ValueChanged += new System.EventHandler(this.numericUpDown_keyLength_ValueChanged);
            // 
            // groupBox_decode
            // 
            this.groupBox_decode.Controls.Add(this.checkBox_oneKey);
            this.groupBox_decode.Controls.Add(this.numericUpDown_periodicitiDecode);
            this.groupBox_decode.Controls.Add(this.checkBox_periodicityDecode);
            this.groupBox_decode.Controls.Add(this.checkBox_randomDecode);
            this.groupBox_decode.Location = new System.Drawing.Point(289, 12);
            this.groupBox_decode.Name = "groupBox_decode";
            this.groupBox_decode.Size = new System.Drawing.Size(235, 115);
            this.groupBox_decode.TabIndex = 1;
            this.groupBox_decode.TabStop = false;
            this.groupBox_decode.Text = "Dekodowanie";
            // 
            // checkBox_oneKey
            // 
            this.checkBox_oneKey.AutoSize = true;
            this.checkBox_oneKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_oneKey.Location = new System.Drawing.Point(20, 80);
            this.checkBox_oneKey.Name = "checkBox_oneKey";
            this.checkBox_oneKey.Size = new System.Drawing.Size(154, 17);
            this.checkBox_oneKey.TabIndex = 3;
            this.checkBox_oneKey.Text = "Wielokrotna iteracja klucza";
            this.checkBox_oneKey.UseVisualStyleBackColor = true;
            this.checkBox_oneKey.CheckedChanged += new System.EventHandler(this.checkBox_oneKey_CheckedChanged);
            // 
            // numericUpDown_periodicitiDecode
            // 
            this.numericUpDown_periodicitiDecode.Location = new System.Drawing.Point(100, 50);
            this.numericUpDown_periodicitiDecode.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_periodicitiDecode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_periodicitiDecode.Name = "numericUpDown_periodicitiDecode";
            this.numericUpDown_periodicitiDecode.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_periodicitiDecode.TabIndex = 2;
            this.numericUpDown_periodicitiDecode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_periodicityDecode
            // 
            this.checkBox_periodicityDecode.AutoSize = true;
            this.checkBox_periodicityDecode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_periodicityDecode.Location = new System.Drawing.Point(20, 50);
            this.checkBox_periodicityDecode.Name = "checkBox_periodicityDecode";
            this.checkBox_periodicityDecode.Size = new System.Drawing.Size(74, 17);
            this.checkBox_periodicityDecode.TabIndex = 1;
            this.checkBox_periodicityDecode.Text = "Okresowe";
            this.checkBox_periodicityDecode.UseVisualStyleBackColor = true;
            this.checkBox_periodicityDecode.CheckedChanged += new System.EventHandler(this.checkBox_periodicityDecode_CheckedChanged);
            // 
            // checkBox_randomDecode
            // 
            this.checkBox_randomDecode.AutoSize = true;
            this.checkBox_randomDecode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_randomDecode.Location = new System.Drawing.Point(20, 20);
            this.checkBox_randomDecode.Name = "checkBox_randomDecode";
            this.checkBox_randomDecode.Size = new System.Drawing.Size(63, 17);
            this.checkBox_randomDecode.TabIndex = 0;
            this.checkBox_randomDecode.Text = "Losowe";
            this.checkBox_randomDecode.UseVisualStyleBackColor = true;
            this.checkBox_randomDecode.CheckedChanged += new System.EventHandler(this.checkBox_randomDecode_CheckedChanged);
            // 
            // groupBox_shortResults
            // 
            this.groupBox_shortResults.Controls.Add(this.label_timer);
            this.groupBox_shortResults.Controls.Add(this.label_executionTime);
            this.groupBox_shortResults.Controls.Add(this.label_averageIt);
            this.groupBox_shortResults.Controls.Add(this.label_maxIt);
            this.groupBox_shortResults.Controls.Add(this.label_minIt);
            this.groupBox_shortResults.Controls.Add(this.label_averageItQuantity);
            this.groupBox_shortResults.Controls.Add(this.label_maxItQuantity);
            this.groupBox_shortResults.Controls.Add(this.label_minItQuantity);
            this.groupBox_shortResults.ForeColor = System.Drawing.Color.Black;
            this.groupBox_shortResults.Location = new System.Drawing.Point(15, 179);
            this.groupBox_shortResults.Name = "groupBox_shortResults";
            this.groupBox_shortResults.Size = new System.Drawing.Size(200, 100);
            this.groupBox_shortResults.TabIndex = 2;
            this.groupBox_shortResults.TabStop = false;
            this.groupBox_shortResults.Text = "Skrócone wyniki";
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(120, 80);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(0, 13);
            this.label_timer.TabIndex = 7;
            // 
            // label_executionTime
            // 
            this.label_executionTime.AutoSize = true;
            this.label_executionTime.Location = new System.Drawing.Point(20, 80);
            this.label_executionTime.Name = "label_executionTime";
            this.label_executionTime.Size = new System.Drawing.Size(90, 13);
            this.label_executionTime.TabIndex = 6;
            this.label_executionTime.Text = "Czas wykonania: ";
            // 
            // label_averageIt
            // 
            this.label_averageIt.AutoSize = true;
            this.label_averageIt.Location = new System.Drawing.Point(120, 60);
            this.label_averageIt.Name = "label_averageIt";
            this.label_averageIt.Size = new System.Drawing.Size(0, 13);
            this.label_averageIt.TabIndex = 5;
            // 
            // label_maxIt
            // 
            this.label_maxIt.AutoSize = true;
            this.label_maxIt.Location = new System.Drawing.Point(120, 40);
            this.label_maxIt.Name = "label_maxIt";
            this.label_maxIt.Size = new System.Drawing.Size(0, 13);
            this.label_maxIt.TabIndex = 4;
            // 
            // label_minIt
            // 
            this.label_minIt.AutoSize = true;
            this.label_minIt.Location = new System.Drawing.Point(120, 20);
            this.label_minIt.Name = "label_minIt";
            this.label_minIt.Size = new System.Drawing.Size(0, 13);
            this.label_minIt.TabIndex = 3;
            // 
            // label_averageItQuantity
            // 
            this.label_averageItQuantity.AutoSize = true;
            this.label_averageItQuantity.Location = new System.Drawing.Point(20, 60);
            this.label_averageItQuantity.Name = "label_averageItQuantity";
            this.label_averageItQuantity.Size = new System.Drawing.Size(82, 13);
            this.label_averageItQuantity.TabIndex = 2;
            this.label_averageItQuantity.Text = "Średnia iteracji: ";
            // 
            // label_maxItQuantity
            // 
            this.label_maxItQuantity.AutoSize = true;
            this.label_maxItQuantity.Location = new System.Drawing.Point(20, 40);
            this.label_maxItQuantity.Name = "label_maxItQuantity";
            this.label_maxItQuantity.Size = new System.Drawing.Size(96, 13);
            this.label_maxItQuantity.TabIndex = 1;
            this.label_maxItQuantity.Text = "Maksimum iteracji: ";
            // 
            // label_minItQuantity
            // 
            this.label_minItQuantity.AutoSize = true;
            this.label_minItQuantity.ForeColor = System.Drawing.Color.Black;
            this.label_minItQuantity.Location = new System.Drawing.Point(20, 20);
            this.label_minItQuantity.Name = "label_minItQuantity";
            this.label_minItQuantity.Size = new System.Drawing.Size(87, 13);
            this.label_minItQuantity.TabIndex = 0;
            this.label_minItQuantity.Text = "Minimum iteracji: ";
            // 
            // button_start
            // 
            this.button_start.ForeColor = System.Drawing.Color.Black;
            this.button_start.Location = new System.Drawing.Point(289, 179);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(235, 100);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_resultFileSource
            // 
            this.textBox_resultFileSource.Location = new System.Drawing.Point(12, 146);
            this.textBox_resultFileSource.Name = "textBox_resultFileSource";
            this.textBox_resultFileSource.Size = new System.Drawing.Size(190, 20);
            this.textBox_resultFileSource.TabIndex = 4;
            this.textBox_resultFileSource.Click += new System.EventHandler(this.textBox_resultFileSource_Click);
            this.textBox_resultFileSource.TextChanged += new System.EventHandler(this.textBox_resultFileSource_TextChanged);
            // 
            // button_resultFileSource
            // 
            this.button_resultFileSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_resultFileSource.Location = new System.Drawing.Point(208, 146);
            this.button_resultFileSource.Name = "button_resultFileSource";
            this.button_resultFileSource.Size = new System.Drawing.Size(75, 20);
            this.button_resultFileSource.TabIndex = 5;
            this.button_resultFileSource.Text = "Ścieżka";
            this.button_resultFileSource.UseVisualStyleBackColor = true;
            this.button_resultFileSource.Click += new System.EventHandler(this.button_resultFileSource_Click);
            // 
            // label_resultFileSource
            // 
            this.label_resultFileSource.AutoSize = true;
            this.label_resultFileSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_resultFileSource.Location = new System.Drawing.Point(12, 130);
            this.label_resultFileSource.Name = "label_resultFileSource";
            this.label_resultFileSource.Size = new System.Drawing.Size(270, 13);
            this.label_resultFileSource.TabIndex = 6;
            this.label_resultFileSource.Text = "Ścieżka pliku wynikowego: Wymagane rozszerzenie .txt";
            // 
            // progressBar_decode
            // 
            this.progressBar_decode.Location = new System.Drawing.Point(289, 133);
            this.progressBar_decode.Name = "progressBar_decode";
            this.progressBar_decode.Size = new System.Drawing.Size(235, 40);
            this.progressBar_decode.TabIndex = 7;
            // 
            // decodingThreadTimer
            // 
            this.decodingThreadTimer.Tick += new System.EventHandler(this.decodingThreadTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.progressBar_decode);
            this.Controls.Add(this.label_resultFileSource);
            this.Controls.Add(this.button_resultFileSource);
            this.Controls.Add(this.textBox_resultFileSource);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox_shortResults);
            this.Controls.Add(this.groupBox_decode);
            this.Controls.Add(this.groupBox_cards);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 330);
            this.MinimumSize = new System.Drawing.Size(550, 330);
            this.Name = "Form1";
            this.Text = "Klucznik Gerwazy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox_cards.ResumeLayout(false);
            this.groupBox_cards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_oneKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_keyLength)).EndInit();
            this.groupBox_decode.ResumeLayout(false);
            this.groupBox_decode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_periodicitiDecode)).EndInit();
            this.groupBox_shortResults.ResumeLayout(false);
            this.groupBox_shortResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox_cards;
        private System.Windows.Forms.Label label_keyQuantity;
        private System.Windows.Forms.Label label_keyLength;
        private System.Windows.Forms.NumericUpDown numericUpDown_keyQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_keyLength;
        private System.Windows.Forms.GroupBox groupBox_decode;
        private System.Windows.Forms.NumericUpDown numericUpDown_periodicitiDecode;
        private System.Windows.Forms.CheckBox checkBox_periodicityDecode;
        private System.Windows.Forms.CheckBox checkBox_randomDecode;
        private System.Windows.Forms.GroupBox groupBox_shortResults;
        private System.Windows.Forms.Label label_averageIt;
        private System.Windows.Forms.Label label_maxIt;
        private System.Windows.Forms.Label label_minIt;
        private System.Windows.Forms.Label label_averageItQuantity;
        private System.Windows.Forms.Label label_maxItQuantity;
        private System.Windows.Forms.Label label_minItQuantity;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_resultFileSource;
        private System.Windows.Forms.Button button_resultFileSource;
        private System.Windows.Forms.Label label_resultFileSource;
        private System.Windows.Forms.ProgressBar progressBar_decode;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_executionTime;
        private System.Windows.Forms.CheckBox checkBox_oneKey;
        private System.Windows.Forms.Label label_oneKey;
        private System.Windows.Forms.NumericUpDown numericUpDown_oneKey;
        private System.Windows.Forms.Timer decodingThreadTimer;
    }
}

