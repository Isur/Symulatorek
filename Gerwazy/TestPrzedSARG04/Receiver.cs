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

        }

        public void Decode(DataStream dataStream, string path)
        {
            using (Saver saver = new Saver(path))
            {

            }
        }
    }
}
