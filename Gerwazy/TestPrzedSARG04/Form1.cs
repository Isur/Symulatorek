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
            textBox3.Text = card.id; 
        }

    }
}
