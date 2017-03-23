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

        public void Dispose()
        {
            this.writer.Close();
            this.writer.Dispose();
        }
    }
}
