using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identificacao
{
    class Pessoa
    {
        private string name;

        public Pessoa(String name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

    }
}
