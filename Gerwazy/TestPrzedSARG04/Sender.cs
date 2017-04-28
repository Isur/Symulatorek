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
        /// <summary>
        /// Creates only one card with random ID
        /// </summary>
        /// <param name="idLength"></param>
        /*public Sender(int idLength)
        {
            Random random = new Random();
            this.card = new Card[1];
            long value = Consts.Power(2, idLength - 1);
            for(int i = 0; i <= idLength - 2; i++)
            {
                value += random.Next(0, 2) == 1 ? Consts.Power(2, idLength - 2 - i) : 0;
            }
            this.card[0] = new Card(Convert.ToString(value, 2));
        }*/
        /// <summary>
        /// Creates range of cards in even distances
        /// </summary>
        /// <param name="cardsAmount"></param>
        /// <param name="idLength"></param>
        public Sender(int cardsAmount, int idLength)
        {
            this.card = new Card[cardsAmount];
            this.setCards(cardsAmount, idLength);
        }
        /// <summary>
        /// Used to pass data about cards as a one argument to Receiver
        /// </summary>
        /// <returns></returns>
        public DataStream SendDataStream()
        {
            return new DataStream(this.card);
        }
        /// <summary>
        /// Set every card with a unique ID
        /// </summary>
        /// <param name="cardsAmount"></param>
        /// <param name="idLength"></param>
        protected void setCards(int cardsAmount, int idLength)
        {
            long min = Consts.Power(2, idLength-1);
            long max = min * 2 - 1;
            long increment = cardsAmount > 1 ? (long)Math.Floor((decimal)((max - min) / (cardsAmount - 1))) : 0;
            long current;

            if(cardsAmount == 1)
            {
                Random random = new Random();
                long value = Consts.Power(2, idLength - 1);
                for (int i = 0; i <= idLength - 2; i++)
                {
                    value += random.Next(0, 2) == 1 ? Consts.Power(2, idLength - 2 - i) : 0;
                }
                current = value;
            }
            else
            {
                current = min;
            }
            
            for(int i=0; i<cardsAmount; i++)
            {
                this.card[i] = new Card(Convert.ToString(current, 2));
                current += increment;
            }
        }
    }
}
