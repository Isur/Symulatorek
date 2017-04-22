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
using System.Threading;

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
            if(textBox_resultFileSource.TextLength > 4)
            {
                if (textBox_resultFileSource.Text.Substring(textBox_resultFileSource.TextLength - 4) != ".txt")
                {
                    button_start.Enabled = false;
                    MessageBox.Show("Wymagany plik o rozszerzeniu .txt", "Błąd!", MessageBoxButtons.OK);
                }
                else
                {
                    readyToStart();
                }
            }
        }
        
        private void everything(bool xD)
        {
            numericUpDown_keyLength.Enabled = xD;
            numericUpDown_keyQuantity.Enabled = xD;
            numericUpDown_oneKey.Enabled = xD;
            checkBox_periodicityDecode.Enabled = xD;
            checkBox_randomDecode.Enabled = xD;
            checkBox_oneKey.Enabled = xD;
            button_start.Enabled = xD;
            button_resultFileSource.Enabled = xD;
            textBox_resultFileSource.Enabled = xD;
            readyToStart();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar_decode.Visible = true;
            progressBar_decode.Maximum = (int) numericUpDown_keyQuantity.Value;
            everything(false);

            this.simulator = new Simulator(this.checkBox_randomDecode.Checked, this.checkBox_periodicityDecode.Checked, this.checkBox_oneKey.Checked, 
                                            (int)this.numericUpDown_keyQuantity.Value, (int)this.numericUpDown_keyLength.Value, (int)this.numericUpDown_periodicitiDecode.Value,
                                            (int)this.numericUpDown_oneKey.Value, this.textBox_resultFileSource.Text, this.progressBar_decode);

            this.label_minIt.Text = this.simulator.GetMinIteration().ToString();
            this.label_maxIt.Text = this.simulator.GetMaxIteration().ToString();
            this.label_averageIt.Text = this.simulator.GetAvgIteration().ToString();
            this.label_timer.Text = this.simulator.GetTimer().ToString();

            everything(true);
        }



        private void numericUpDown_keyLength_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_keyQuantity.Maximum = (long)Math.Pow(2, ((long)numericUpDown_keyLength.Value - 1));
            if ((long)numericUpDown_keyQuantity.Maximum >= 100000) numericUpDown_keyQuantity.Maximum = 100000;
        }
                
        private void textBox_resultFileSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_randomDecode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_randomDecode.Checked == true)
            {
                checkBox_periodicityDecode.Checked = false;
                numericUpDown_periodicitiDecode.Enabled = false;
            }
            readyToStart();
        }

        private void checkBox_periodicityDecode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_periodicityDecode.Checked == true)
            {
                checkBox_randomDecode.Checked = false;
                numericUpDown_periodicitiDecode.Enabled = true;
            }
            else
            {
                numericUpDown_periodicitiDecode.Enabled = false;
            }
            readyToStart();
        }

        private void checkBox_oneKey_CheckedChanged(object sender, EventArgs e)
        {
            readyToStart();
        }

        private void readyToStart()
        {
            if (checkBox_oneKey.Checked == true)
            {
                label_oneKey.Enabled = true;
                numericUpDown_oneKey.Enabled = true;
            }
            else
            {
                label_oneKey.Enabled = false;
                numericUpDown_oneKey.Enabled = false;
                numericUpDown_keyQuantity.Enabled = true;
            }
            if(checkBox_randomDecode.Checked ^ checkBox_periodicityDecode.Checked)
            {
                if (textBox_resultFileSource.Text != "")
                {
                    button_start.Enabled = true;
                }else button_start.Enabled = false;
            }else button_start.Enabled = false;
        }
    }
}
