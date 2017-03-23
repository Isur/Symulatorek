using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
