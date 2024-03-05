using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{    class ToDo
    {
        private string Name;
        private string DateDo;
        private string Discr;
        public ToDo(string name, string dateDo, string discr)
        {
            Name = name;
            DateDo = dateDo;
            Discr = discr;
        }
        public string NameS
        {
            get { return Name; }
            set { Name = value; }
        }
        public string DateDoS
        {
            get { return DateDo; }
            set { DateDo = value; }
        }
        public string DiscrS
        {
            get { return Discr; }
            set { Discr = value; }
        }

    }
}
