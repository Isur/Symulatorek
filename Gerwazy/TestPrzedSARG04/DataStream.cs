using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerwazy
{
    class DataStream
    {
        public Card[] card { get; protected set; }
        public string[] codedId { get; protected set; }
        public string[] complementedId { get; protected set; }

        //METHODS
        public DataStream(Card[] card)
        {
            this.card = card;
            this.codeAndCompliment();
        }

        protected void codeAndCompliment()
        {

        }
    }
}
