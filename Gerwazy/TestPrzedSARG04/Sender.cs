using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerwazy
{
    class Sender
    {
        protected Card[] card;

        //METHODS
        public Sender(int cardsAmount, int idLength)
        {
            this.card = new Card[cardsAmount];
            this.setCards(cardsAmount, idLength);
        }

        public DataStream SendDataStream()
        {
            return new DataStream(this.card);
        }

        protected void setCards(int cardsAmount, int idLength)
        {
            long min = Consts.Power(2, idLength-1);
            long max = min * 2 - 1;
            long increment = cardsAmount > 1 ? (long)Math.Floor((decimal)((max - min) / (cardsAmount - 1))) : 0;
            long current = min;
            
            for(int i=0; i<cardsAmount; i++)
            {
                this.card[i] = new Card(Convert.ToString(current, 2));
                current += increment;
                MessageBox.Show(card[i].id);
            }
        }
    }
}
