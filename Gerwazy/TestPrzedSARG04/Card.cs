using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerwazy
{
    class Card
    {
        public string id { get; protected set; }
        
        //METHODS
        public Card(string id)
        {
            this.id = id;
        }
    }
}
