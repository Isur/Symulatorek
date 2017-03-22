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

namespace TestPrzedSARG04
{
    public partial class Form1 : Form
    {
        long dec;
        string bitArray;
        char[] codedArray;
        char[] bases;

        public Form1()
        {
            InitializeComponent();

            dec = (long)Math.Pow(2, 60);
            bitArray = Convert.ToString(dec,2);

            for(int i=0; i<bitArray.Length; i++)
            {
                this.textBox1.Text += bitArray[i];
            }

            /*bitArray = new List<bool>();
            bitArray.Capacity = 2;
            bitArray.Add(true);
            bitArray.Add(false);
            bitArray[0] = false;*/


           /* bitArray = new bool[(int)numeric.Value];
            codedArray = new char[(int)numeric.Value];
            bases = new char[(int)numeric.Value];

            Random random = new Random();

            bitArray[0] = true;/////////////////////wszystko chujowe jak barszcz (matematyczna porażka)
            textBox1.Text += "1";
            codedArray[0] = Consts.polarization[1, random.Next() % 2];
            textBox2.Text += codedArray[0].ToString();
            bases[0] = Consts.Base[random.Next() % 2];
            textBox3.Text += bases[0].ToString();
            for (int i=1; i<bitArray.Length; i++)/////////////////////////ulepszyć
            {
                bitArray[i] = random.Next() % 2 == 0 ? true : false;
                codedArray[i] = Consts.polarization[bitArray[i] ? 1 : 0, random.Next() % 2];
                bases[i] = Consts.Base[random.Next() % 2];

                textBox1.Text += bitArray[i] ? "1" : "0";
                textBox2.Text += codedArray[i].ToString();
            }*/
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.ShowDialog();
            textBox3.Text = saveFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
