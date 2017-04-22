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

        //METHODS 
        public Simulator(bool isRandom, bool isPeriod, bool isRepeatable, int cardsAmount, int idLenght, int period, int repeats, string path, ProgressBar progressBar)
        {
            this.receiver = new Receiver(path);
            this.sender = new Sender(cardsAmount, idLenght);

            this.receiver.Decode(this.sender.SendDataStream(), progressBar, isRandom, isPeriod, isRepeatable, period, repeats);

            //Form form = new Form();
            //Thread thread = new Thread(new ThreadStart(form.Activate));
            //thread.Start();

            /*if (isRepeatable)
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
            }*/

            //thread.Abort();
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
