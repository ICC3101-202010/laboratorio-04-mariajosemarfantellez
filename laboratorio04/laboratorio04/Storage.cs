using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    class Storage : CentralComputer, IMemory
    {
        private int MemorySto;
        public Storage(int MemorySto)
        {
            this.MemorySto = MemorySto;
        }
        public override void On()
        {
            Console.WriteLine("Storage se acaba de prender, su memoria parte desde 0\n");
            MemorySto = 0;
        } 
        Random rnd = new Random();
        string respuesta;
        public int Memory()
        {
            int MemorySto = rnd.Next(0, 10);
            if (MemorySto == 3)
            {
                Console.WriteLine("Storage debe reiniciarse, ya que su memoria ha llegado a 3\n");
                return MemorySto;
            }
            else { return 0; }
        }
        public override void Restart(int MemorySto)
        {
            if (MemorySto == 3)
            {
                Console.WriteLine("Diga la máquina que desea reiniciar: r -> Reception, s -> Storage, a -> Assembly, c -> Check, p -> Packing\n");
                respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    Console.WriteLine("Storage se ha reiniciado y su memoria vuelve a 0\n");
                    MemorySto = 0;
                }
                else { }
            }
            else { }
        }
        public override void Off()
        {
            Console.WriteLine("Storage se apagó\n");
            MemorySto = 0;
        }
    }
}
