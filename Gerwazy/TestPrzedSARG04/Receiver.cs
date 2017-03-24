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

        //METHODS
        public Receiver()
        {
            this.minIteration = 0;
            this.maxIteration = 0;
            this.avgIteration = 0;
        }

        public void Decode(DataStream dataStream, string path, bool isPeriod, int period)
        {
            Random random = new Random();

            int[] iteration = new int[dataStream.card.Length];
            int[] solved = new int[dataStream.card.Length];
            char[] result = new char[dataStream.codedId[0].Length];

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

                    for(int j = 0; j<dataStream.codedId[0].Length; j++)
                    {
                        result[j] = Consts.Result[0];
                    }

                    while(solved[i] < dataStream.codedId[0].Length)
                    {
                        string bases = "";
                        string results = "";

                        for(int j = 0; j<dataStream.codedId[0].Length; j++)
                        {
                            if (result[j] == Consts.Result[0])
                            {
                                bases += random.Next(0, 2) == 0 ? Consts.Base[0] : Consts.Base[1];

                                if (bases[j] == Consts.Base[0] && (dataStream.codedId[i][j] == Consts.Polarization[0, 0] || dataStream.codedId[i][j] == Consts.Polarization[0, 1]))
                                {
                                    results += dataStream.codedId[i][j];
                                    result[j] = Consts.Result[0];
                                }
                                else if (bases[j] == Consts.Base[1] && (dataStream.codedId[i][j] == Consts.Polarization[0, 0] || dataStream.codedId[i][j] == Consts.Polarization[0, 1]))
                                {
                                    results += Consts.Polarization[1, random.Next(0,2)];

                                    if (results[j] != dataStream.complementedId[i][j])
                                    {
                                        result[j] = Consts.Result[1];
                                        solved[i]++;
                                    }
                                    else
                                        result[j] = Consts.Result[0];
                                }
                                else if (bases[j] == Consts.Base[0] && (dataStream.codedId[i][j] == Consts.Polarization[1, 0] || dataStream.codedId[i][j] == Consts.Polarization[1, 1]))
                                {
                                    results += Consts.Polarization[0, random.Next(0, 2)];

                                    if (results[j] != dataStream.complementedId[i][j])
                                    {
                                        result[j] = Consts.Result[1];
                                        solved[i]++;
                                    }
                                    else
                                        result[j] = Consts.Result[0];
                                }
                                else if (bases[j] == Consts.Base[1] && (dataStream.codedId[i][j] == Consts.Polarization[1, 0] || dataStream.codedId[i][j] == Consts.Polarization[1, 1]))
                                {
                                    results += dataStream.codedId[i][j];
                                    result[j] = Consts.Result[0];
                                }
                            }
                            else
                            {
                                results += " ";
                                bases += " ";
                            }
                        }
                        saver.Save(bases);
                        saver.Save(results);
                    }
                    saver.Save("\n\n\n");
                }
            }
        }
    }
}
