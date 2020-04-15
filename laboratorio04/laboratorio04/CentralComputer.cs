using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    public abstract class CentralComputer
    {
        public abstract void On(); 
        public abstract void Restart(int Memory);
        public abstract void Off();
    }
}
