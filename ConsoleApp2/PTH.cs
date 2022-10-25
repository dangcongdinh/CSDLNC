using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PTH
    {
        public string vt { set; get; }
        public string vp { set; get; }
        public PTH()
        {

        }
        public PTH(string vt, string vp)
        {
            this.vt = vt;
            this.vp = vp;
        }
        public override string ToString()
        {
            return $"{vt}->{vp}\n ";
        }
    }
}
