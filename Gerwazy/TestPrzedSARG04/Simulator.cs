using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerwazy
{
    class Simulator
    {
        protected Sender sender;
        protected Receiver receiver;

        //METHODS 
        public Simulator(int cardsAmount, int idLenght, string path, bool isPeriod, int period)
        {
            this.sender = new Sender(cardsAmount, idLenght);
            this.receiver = new Receiver();

            this.receiver.Decode(this.sender.SendDataStream(), path, isPeriod, period);
        }
    }
}
