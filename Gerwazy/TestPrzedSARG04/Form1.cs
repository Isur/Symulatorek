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

            this.simulator = new Simulator();

            Card card = new Card(Convert.ToString(13213, 2)); //to jest tylko do testów

            numericUpDown_periodicitiDecode.Enabled = false;
            button_start.Enabled = false;
            progressBar_decode.Visible = false;
            checkBox_randomDecode.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown_periodicitiDecode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_resultFileSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
            saveFileDialog1.ShowDialog();
            textBox_resultFileSource.Text = saveFileDialog1.FileName;
            button_start.Enabled = true;
        }

        private void groupBox_shortResults_Enter(object sender, EventArgs e)
        {

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
            // TU ROBOTA DLA CIEBIExD!  // FUNKCJA KTORA MA DZIALAC
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
        }
    }
}
