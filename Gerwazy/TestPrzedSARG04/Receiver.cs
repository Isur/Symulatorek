using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerwazy
{
    class Receiver
    {
        public int minIteration { get; protected set; }
        public int maxIteration { get; protected set; }
        public int avgIteration { get; protected set; }
        //protected int[] iteration;
        //protected int[] solved;
        //protected char[,] result;

        //METHODS
        public Receiver()
        {
            this.minIteration = 0;
            this.maxIteration = 0;
            this.avgIteration = 0;
        }

        public void Decode(DataStream dataStream, string path, bool isPeriod, int period)
        {
            int[] iteration = new int[dataStream.card.Length];
            int[] solved = new int[dataStream.card.Length];
            char[] result = new char[dataStream.codedId.Length];

            using (Saver saver = new Saver(path))
            {
                for(int i = 0; i<dataStream.card.Length; i++)
                {
                    saver.Save(dataStream.card[i].id);
                    saver.Save(dataStream.codedId[i]);
                    saver.Save(dataStream.complementedId[i]);
                    saver.Save("");

                    iteration[i] = 0;
                    solved[i] = 0;

                    for(int j = 0; j<dataStream.codedId.Length; j++)
                    {
                        result[j] = Consts.Result[0];
                    }

                    while(solved[i] < dataStream.codedId.Length)
                    {
                        for(int j = 0; j<dataStream.codedId.Length; j++)
                        {
                            solved[i]++;
                        }
                    }
                }
            }
        }
    }
}
