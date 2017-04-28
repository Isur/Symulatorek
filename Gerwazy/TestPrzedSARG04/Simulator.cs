using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Gerwazy
{
    class Simulator
    {
        protected Sender sender;
        protected Receiver receiver;

        protected ProgressBar progressBar;
        protected bool isRandom;
        protected bool isPeriod;
        protected bool isRepeatable;
        protected int period;
        protected int repeats;

        //METHODS 
        public Simulator(bool isRandom, bool isPeriod, bool isRepeatable, int cardsAmount, int idLenght, int period, int repeats, string path, ProgressBar progressBar)
        {
            this.receiver = new Receiver(path);
            this.sender = new Sender(cardsAmount, idLenght);

            this.progressBar = progressBar;
            this.isPeriod = isPeriod;
            this.isRandom = isRandom;
            this.isRepeatable = isRepeatable;
            this.period = period;
            this.repeats = repeats;
        }
        public void Decode()
        {
            this.receiver.Decode(this.sender.SendDataStream(), this.progressBar, this.isRandom, this.isPeriod, this.isRepeatable, this.period, this.repeats);
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
