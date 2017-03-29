using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerwazy
{
    class Receiver
    {
        public int minIteration { get; protected set; }
        public int maxIteration { get; protected set; }
        public double avgIteration { get; protected set; }

        //METHODS
        public Receiver()
        {
            this.minIteration = 10000;
            this.maxIteration = 0;
            this.avgIteration = 0;
        }

        public void Decode(DataStream dataStream, string path, bool isPeriod, int period, ProgressBar progressBar)
        {
            Random random = new Random();

            progressBar.Value = 0;
            progressBar.Maximum = dataStream.card.Length;

            int[] iteration = new int[dataStream.card.Length];//
            int[] solved = new int[dataStream.card.Length];// to i to wyżej nie musi być tablicą, wystarczy zmienna resetowana na początku pętli
            char[] result = new char[dataStream.codedId[0].Length];

            using (Saver saver = new Saver(path))
            {
                for (int i = 0; i < dataStream.card.Length; i++)
                {
                    iteration[i] = 0;

                    saver.Save(dataStream.card[i].id);
                    saver.Save(dataStream.codedId[i]);
                    saver.Save(dataStream.complementedId[i]);
                    saver.Save("");

                    iteration[i] = 0;
                    solved[i] = 0;

                    for (int j = 0; j < dataStream.codedId[0].Length; j++)
                    {
                        result[j] = Consts.Result[0];
                    }

                    while (solved[i] < dataStream.codedId[0].Length)
                    {
                        string bases = "";
                        string resultPolarizations = "";
                        iteration[i]++;

                        for (int j = 0; j < dataStream.codedId[0].Length; j++)
                        {
                            if (result[j] == Consts.Result[0])
                            {
                                bases += random.Next(0, 2) == 0 ? Consts.Base[0] : Consts.Base[1];

                                if (bases[j] == Consts.Base[0] && (dataStream.codedId[i][j] == Consts.Polarization[0, 0] || dataStream.codedId[i][j] == Consts.Polarization[0, 1]))
                                {
                                    resultPolarizations += dataStream.codedId[i][j];
                                    result[j] = Consts.Result[0];
                                }
                                else if (bases[j] == Consts.Base[1] && (dataStream.codedId[i][j] == Consts.Polarization[0, 0] || dataStream.codedId[i][j] == Consts.Polarization[0, 1]))
                                {
                                    resultPolarizations += Consts.Polarization[1, random.Next(0, 2)];

                                    if (resultPolarizations[j] != dataStream.complementedId[i][j])
                                    {
                                        result[j] = Consts.Result[1];
                                        solved[i]++;
                                    }
                                    else
                                        result[j] = Consts.Result[0];
                                }
                                else if (bases[j] == Consts.Base[0] && (dataStream.codedId[i][j] == Consts.Polarization[1, 0] || dataStream.codedId[i][j] == Consts.Polarization[1, 1]))
                                {
                                    resultPolarizations += Consts.Polarization[0, random.Next(0, 2)];

                                    if (resultPolarizations[j] != dataStream.complementedId[i][j])
                                    {
                                        result[j] = Consts.Result[1];
                                        solved[i]++;
                                    }
                                    else
                                        result[j] = Consts.Result[0];
                                }
                                else if (bases[j] == Consts.Base[1] && (dataStream.codedId[i][j] == Consts.Polarization[1, 0] || dataStream.codedId[i][j] == Consts.Polarization[1, 1]))
                                {
                                    resultPolarizations += dataStream.codedId[i][j];
                                    result[j] = Consts.Result[0];
                                }
                            }
                            else
                            {
                                resultPolarizations += " ";
                                bases += " ";
                            }
                        }
                        saver.Save(bases);
                        saver.Save(resultPolarizations);
                    }
                    saver.Save("\n\n\n");
                    progressBar.Value++;

                    this.minIteration = this.minIteration < iteration[i] ? this.minIteration : iteration[i];
                    this.maxIteration = this.maxIteration > iteration[i] ? this.maxIteration : iteration[i];
                    this.avgIteration += iteration[i];
                }
                this.avgIteration /= dataStream.card.Length;
            }
        }
    }
}

