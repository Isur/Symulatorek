using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gerwazy
{
    class Saver : IDisposable
    {
        StreamWriter writer;

        //METHODS
        public Saver(string path)
        {
            this.writer = new StreamWriter(path);
        }
        /// <summary>
        /// Saves data with space between every char
        /// </summary>
        /// <param name="data"></param>
        public void SaveData(string data)
        {
            string spacedData = "";

            for(int i = 0; i<data.Length; i++)
            {
                spacedData += data[i] + " ";
            }

            this.writer.WriteLine(spacedData);
        }
        /// <summary>
        /// Saves raw data without any formating
        /// </summary>
        /// <param name="data"></param>
        public void Save(string data)
        {
            this.writer.WriteLine(data);
        }
        public void Dispose()
        {
            this.writer.Close();
            this.writer.Dispose();
        }
    }
}
