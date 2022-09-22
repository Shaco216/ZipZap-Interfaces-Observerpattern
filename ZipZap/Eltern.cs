using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipZap
{
    internal class  Eltern : Observer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Eltern(string name)
        {
            this.name = name;
        }

        public void Observe()
        {
            Console.WriteLine(this.name+" wurde benachrichtigt");
        }
    }
}
