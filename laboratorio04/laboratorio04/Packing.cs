using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    class Packing : CentralComputer, IMemory
    {
        private int MemoryPac;
        public Packing(int MemoryPac)
        {
            this.MemoryPac = MemoryPac;
        }
        public override void On()
        {
            Console.WriteLine("Packing se acaba de prender, su memoria parte desde 0\n");
            MemoryPac = 0;
        }
        Random rnd = new Random();
        string respuesta;
        public int Memory()
        {
            int MemoryPac = rnd.Next(0, 10);
            if (MemoryPac == 9)
            {
                Console.WriteLine("Packing debe reiniciarse, ya que su memoria ha llenado...");
                System.Threading.Thread.Sleep(500);
                return MemoryPac;
            }
            else { return 0; }
        }
        public override void Restart(int MemoryPac)
        {
            if (MemoryPac == 9)
            {
                Console.WriteLine("Packing se ha reiniciado y su memoria vuelve a 0\n");
                MemoryPac = 0;
            }
            else { }
        }
        public override void Off()
        {
            Console.WriteLine("Packing se apagó\n");
            MemoryPac = 0;
        }
    }
}
