using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerwazy
{
    delegate void Decoder(int period, int i, int j);

    class Receiver
    {
        public int minIteration { get; protected set; }
        public int maxIteration { get; protected set; }
        public int avgIteration { get; protected set; }
        protected int[] iteration;
        protected int[] solved;
        protected char[,] result;

        //METHODS
        public Receiver()
        {
            this.minIteration = 0;
            this.maxIteration = 0;
            this.avgIteration = 0;
        }

        public void Decode(DataStream dataStream, string path, bool isPeriod, int period)
        {
            this.iteration = new int[dataStream.card.Length];
            this.solved = new int[dataStream.card.Length];
            this.result = new char[dataStream.card.Length, dataStream.codedId.Length];

            Decoder decoder;
            if (isPeriod)
                decoder = this.decodePeriod;
            else
                decoder = this.decodeRandom;

            using (Saver saver = new Saver(path))
            {
                for(int i = 0; i<dataStream.card.Length; i++)
                {
                    saver.Save(dataStream.card[i].id);
                    saver.Save(dataStream.codedId[i]);
                    saver.Save(dataStream.complementedId[i]);
                    saver.Save("");

                    this.iteration[i] = 0;
                    this.solved[i] = 0;
                    for(int j = 0; j<dataStream.codedId.Length; j++)
                    {
                        result[i,j] = Consts.Result[0];
                    }

                    while(this.solved[i] < dataStream.codedId.Length)
                    {
                        for(int j = 0; j<dataStream.codedId.Length; j++)
                        {
                            decoder(period, i, j);
                        }
                    }
                }
            }
        }

        protected void decodeRandom(int period, int i, int j)
        {
            solved[i]++;
        }

        protected void decodePeriod(int period, int i, int j)
        {
            solved[i]++;
        }
    }
}
