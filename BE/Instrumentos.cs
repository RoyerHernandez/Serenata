using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Instrumentos : IBE
    {
        private string instrumento;
        public string Instrumento
        {
            get { return instrumento; }
            set { instrumento = value; }
        }
        public string crear()
        {
            return "Es el " + this.instrumento;
        }
    }
}
