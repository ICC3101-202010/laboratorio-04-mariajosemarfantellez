using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    class Assembly : CentralComputer, IMemory
    {
        private int MemoryAsse;
        public Assembly(int MemoryAsse)
        {
            this.MemoryAsse = MemoryAsse;
        }
        public override void On()
        {
            Console.WriteLine("Assembly se acaba de prender, su memoria parte desde 0\n");
            MemoryAsse = 0;
        }
        Random rnd = new Random();
        string respuesta;
        public int Memory()
        {
            int MemoryAsse = rnd.Next(0, 10);
            if (MemoryAsse == 5)
            {
                Console.WriteLine("Assembly debe reiniciarse, ya que su memoria ha llenado...");
                System.Threading.Thread.Sleep(500);
                return MemoryAsse;
            }
            else { return 0; }
        }
        public override void Restart(int MemoryAsse)
        {
            if (MemoryAsse == 5)
            {
                Console.WriteLine("Assembly se ha reiniciado y su memoria vuelve a 0\n");
                MemoryAsse = 0;
            }
            else { }
        }
        public override void Off()
        {
            Console.WriteLine("Assembly se apagó\n");
            MemoryAsse = 0;
        }
    }
}
