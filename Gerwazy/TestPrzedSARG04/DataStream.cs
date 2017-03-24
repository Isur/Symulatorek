using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerwazy
{
    class DataStream
    {
        public Card[] card { get; protected set; }
        public string[] codedId { get; protected set; }
        public string[] complementedId { get; protected set; }

        //METHODS
        public DataStream(Card[] card)
        {
            this.card = card;
            this.codedId = new string[this.card.Length];
            this.complementedId = new string[this.card.Length];
            this.codeAndCompliment();
        }

        protected void codeAndCompliment()
        {
            Random random = new Random();

            for (int i = 0; i < this.card.Length; i++)
            {
                for (int j = 0; j < card[0].id.Length; j++)
                {
                    if(this.card[i].id[j] == '1')
                    {
                        this.codedId[i] += Consts.Polarization[1, random.Next(0,2)];
                        this.complementedId[i] += Consts.Polarization[0, random.Next(0, 2)];
                    }
                    else
                    {
                        this.codedId[i] += Consts.Polarization[0, random.Next(0, 2)];
                        this.complementedId[i] += Consts.Polarization[1, random.Next(0, 2)];
                    }
                }
            }
        }
    }
}
