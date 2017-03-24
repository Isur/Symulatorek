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

        public void Save(string data)
        {
            string spacedData = "";

            for(int i = 0; i<data.Length; i++)
            {
                spacedData += data[i] + " ";
            }

            this.writer.WriteLine(spacedData);
        }

        public void Dispose()
        {
            this.writer.Close();
            this.writer.Dispose();
        }
    }
}
