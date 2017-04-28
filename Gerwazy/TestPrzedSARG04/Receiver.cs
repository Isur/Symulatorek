using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public string timer { get; protected set; }

        protected string path;

        //METHODS
        public Receiver(string path)
        {
            this.minIteration = 10000;
            this.maxIteration = 0;
            this.avgIteration = 0;
            this.timer = "00:00.00";
            this.path = path;
        }

        /// <summary>
        /// Universal decoding method
        /// </summary>
        /// <param name="dataStream"></param>
        /// <param name="progressBar"></param>
        /// <param name="isRandom"></param>
        /// <param name="isPeriodic"></param>
        /// <param name="isRepeatable"></param>
        /// <param name="period"></param>
        /// <param name="repeats"></param>
        public void Decode(DataStream dataStream, ProgressBar progressBar, bool isRandom, bool isPeriodic, bool isRepeatable, int period, int repeats)
        {
            int idLength = dataStream.codedId[0].Length;
            int cardAmount = dataStream.card.Length;
            int determinant = -1;
            int adder = -1;

            //Random is needed for generating bases and sometimes results
            Random random = new Random(); 

            //Setting prograss bar
            progressBar.Value = 0;
            progressBar.Maximum = cardAmount * (isRepeatable ? repeats : 1);

            //Setting local variables needed for checking each iteration status
            int iteration = 0;
            int solved = 0;
            char[] result = new char[idLength];

            //Seeting a Saver object in using statement
            using (Saver saver = new Saver(this.path))
            {
                //Setting watch to check the time of the whole operation
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                //Loop for each card
                for (int i = 0; i < cardAmount; i++)
                {
                    //Loop for repeatable decoding
                    for(int k = 0; k < (isRepeatable ? repeats : 1); k++)
                    {
                        //Saving card info
                        saver.SaveData(dataStream.card[i].id);
                        saver.SaveData(dataStream.codedId[i]);
                        saver.SaveData(dataStream.complementedId[i]);
                        saver.SaveData("");

                        //Resetting variables for the next card to be checked
                        iteration = 0;
                        solved = 0;
                        for (int j = 0; j < idLength; j++)
                        {
                            result[j] = Consts.Result[0];
                        }
                        determinant = -1;
                        adder = -1;

                        //Loop for as long as it takes to decode the card
                        while (solved < idLength)
                        {
                            //Setting||Clearing bases and results
                            string bases = "";
                            string resultPolarizations = "";

                            iteration++;

                            //Loop for each bit in card's ID
                            for (int j = 0; j < idLength; j++)
                            {
                                //checking if bit hasn't been decoded yet
                                if (result[j] == Consts.Result[0])
                                {
                                    //Setting base
                                    if(isRandom)
                                        bases += random.Next(0, 2) == 0 ? Consts.Base[0] : Consts.Base[1];
                                    else
                                        bases += determinant > 0 ? Consts.Base[0] : Consts.Base[1];

                                    //Checking the result
                                    if (bases[j] == Consts.Base[0] && (dataStream.codedId[i][j] == Consts.Polarization[0, 0] || dataStream.codedId[i][j] == Consts.Polarization[0, 1]))
                                    {
                                        resultPolarizations += dataStream.codedId[i][j];
                                        result[j] = Consts.Result[0];
                                    }
                                    else if (bases[j] == Consts.Base[1] && (dataStream.codedId[i][j] == Consts.Polarization[1, 0] || dataStream.codedId[i][j] == Consts.Polarization[1, 1]))
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
                                            solved++;
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
                                            solved++;
                                        }
                                        else
                                            result[j] = Consts.Result[0];
                                    }
                                }
                                else
                                {
                                    resultPolarizations += " ";
                                    bases += " ";
                                }
                            }
                            if(isPeriodic)
                            {
                                determinant += adder;
                                if (determinant > period || determinant < -period)
                                {
                                    adder *= -1;
                                    determinant = adder;
                                }
                            }
                            //Saving bases and results every step
                            saver.SaveData(bases);
                            saver.SaveData(resultPolarizations);
                        }
                        //Updating progressbar after succesfully decoded card
                        saver.SaveData("\n\n\n");
                        //progressBar.Value=1; ////////////////////////////////////////////////////////////////

                        //Checking if new iteration number is min or max
                        this.minIteration = this.minIteration < iteration ? this.minIteration : iteration;
                        this.maxIteration = this.maxIteration > iteration ? this.maxIteration : iteration;
                        this.avgIteration += iteration;
                    }
                }
                //Calculating avg iteration value
                this.avgIteration /= cardAmount * (isRepeatable ? repeats : 1);
                this.avgIteration = Math.Round(this.avgIteration, 2);

                stopwatch.Stop();
                this.timer = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");

                //Saving final serults
                saver.Save("Długość ID: " + idLength);
                saver.Save("Ilość ID: " + cardAmount);
                if(isRepeatable) saver.Save("Ilość dekodowań każdego ID: " + repeats);
                saver.Save("Minimalna ilość iteracji: " + this.minIteration.ToString());
                saver.Save("Maksymalna ilość iteracji: " + this.maxIteration.ToString());
                saver.Save("Średnia ilość iteracji: " + this.avgIteration.ToString());
                saver.Save("Całkowity czas obliczeń(mm:ss.ff): " + this.timer);
            }
        }
    }
}

