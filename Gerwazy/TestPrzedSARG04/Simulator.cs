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
        public Simulator(int cardsAmount, int idLenght, bool isPeriod, int period ,bool isRepeatable, int repeats, string path, ProgressBar progressBar)
        {
            this.receiver = new Receiver(path);

            if (isRepeatable)
            {
                this.sender = new Sender(idLenght);
                this.receiver.DecodeRepeatly(this.sender.SendDataStream(), progressBar, repeats);
            }
            else
            {
                this.sender = new Sender(cardsAmount, idLenght);
                if (isPeriod)
                    this.receiver.DecodPeriodically(this.sender.SendDataStream(), progressBar, period);
                else
                    this.receiver.DecodeStandard(this.sender.SendDataStream(), progressBar);
            }
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
        public string GetTimer()
        {
            return this.receiver.timer;
        }
    }
}
