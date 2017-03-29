using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerwazy
{
    class Simulator
    {
        protected Sender sender;
        protected Receiver receiver;

        //METHODS 
        public Simulator(int cardsAmount, int idLenght, string path, bool isPeriod, int period ,ProgressBar progressBar)
        {
            this.sender = new Sender(cardsAmount, idLenght);
            this.receiver = new Receiver();

            this.receiver.Decode(this.sender.SendDataStream(), path, isPeriod, period, progressBar);
        }

        public int GetMinIteration()
        {
            return this.receiver.minIteration;
        }

        public int GetMaxIteration()
        {
            return this.receiver.maxIteration;
        }

        public double GetAvgIteration()
        {
            return this.receiver.avgIteration;
        }
    }
}
