using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Gerwazy
{
    public partial class Form1 : Form
    {
        Simulator simulator;

        public Form1()
        {
            InitializeComponent();

            button_start.Enabled = false;
            progressBar_decode.Visible = false;
            checkBox_randomDecode.Checked = true;
            checkBox_periodicityDecode.Checked = false;
            numericUpDown_periodicitiDecode.Enabled = false;
        }

        private void textBox_resultFileSource_Click(object sender, EventArgs e)
        {
            resultFileSource();
        }

        private void button_resultFileSource_Click(object sender, EventArgs e)
        {
            resultFileSource();
        }

        private void resultFileSource()
        {
            saveFileDialog1.Filter = "Text|*.txt|All|*.*";
            saveFileDialog1.ShowDialog();
            textBox_resultFileSource.Text = saveFileDialog1.FileName;
            if (textBox_resultFileSource.Text.Substring(textBox_resultFileSource.TextLength - 4) != ".txt")
            {
                button_start.Enabled = false;
                MessageBox.Show("Wymagany plik o rozszerzeniu .txt", "Błąd!", MessageBoxButtons.OK);
            }
            else
            {
                button_start.Enabled = true;
            }            
        }
        
        private void everything(bool xD)
        {
            numericUpDown_keyLength.Enabled = xD;
            numericUpDown_keyQuantity.Enabled = xD;
            numericUpDown_periodicitiDecode.Enabled = xD;
            checkBox_periodicityDecode.Enabled = xD;
            checkBox_randomDecode.Enabled = xD;
            button_start.Enabled = xD;
            button_resultFileSource.Enabled = xD;
            textBox_resultFileSource.Enabled = xD;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar_decode.Visible = true;
            progressBar_decode.Maximum = (int) numericUpDown_keyQuantity.Value;
            everything(false);

            this.simulator = new Simulator((int)this.numericUpDown_keyQuantity.Value, (int)this.numericUpDown_keyLength.Value, 
                                            this.textBox_resultFileSource.Text, this.checkBox_periodicityDecode.Checked, 
                                            (int)this.numericUpDown_periodicitiDecode.Value, this.progressBar_decode);
            this.label_minIt.Text = this.simulator.GetMinIteration().ToString();
            this.label_maxIt.Text = this.simulator.GetMaxIteration().ToString();
            this.label_averageIt.Text = this.simulator.GetAvgIteration().ToString();
            this.label_timer.Text = this.simulator.GetTimer().ToString();

            everything(true);
        }

        private void checkBox_periodicityDecode_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_periodicityDecode.Checked == true)
            {
                numericUpDown_periodicitiDecode.Enabled = true;
            }
            else
            {
                numericUpDown_periodicitiDecode.Enabled = false;
            }
            if (checkBox_periodicityDecode.Checked == true) checkBox_randomDecode.Checked = false;
            else checkBox_randomDecode.Checked = true;
        }

        private void numericUpDown_keyLength_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_keyQuantity.Maximum = (long)Math.Pow(2, ((long)numericUpDown_keyLength.Value - 1));
           
        }

        private void checkBox_randomDecode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_randomDecode.Checked == true) checkBox_periodicityDecode.Checked = false;
            else checkBox_periodicityDecode.Checked = true;
        }

        private void textBox_resultFileSource_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
