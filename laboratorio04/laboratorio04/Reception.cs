using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    class Reception : CentralComputer, IMemory
    {
        private int MemoryRec; 
        public Reception(int MemoryRec)
        {
            this.MemoryRec = MemoryRec;
        }

        public override void On()
        {
            Console.WriteLine("Reception se acaba de prender, su memoria parte desde 0\n");
            MemoryRec = 0;
        }

        Random rnd = new Random();
        string respuesta;
        public int Memory()
        {
            int MemoryRec = rnd.Next(0, 10);
            if (MemoryRec == 1)
            {
                Console.WriteLine("Reception debe reiniciarse, ya que su memoria ha llenado...");
                System.Threading.Thread.Sleep(500);
                return MemoryRec;
            }
            else{ return 0; }
        }
        public override void Restart(int MemoryRec)
        {
            if (MemoryRec == 1)
            {
                Console.WriteLine("Reception se ha reiniciado y su memoria vuelve a 0\n");
                MemoryRec = 0;
            }
            else { }
            
        }
        public override void Off()
        {
            Console.WriteLine("Reception se apagó\n");
            MemoryRec = 0;
        }
    }
}
