using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    class Check : CentralComputer, IMemory
    {
        private int MemoryChe;
        public Check(int MemoryChe)
        {
            this.MemoryChe = MemoryChe;
        }
        public override void On()
        {
            Console.WriteLine("Check se acaba de prender, su memoria parte desde 0\n");
            MemoryChe = 0;
        }

        Random rnd = new Random();
        string respuesta;
        public int Memory()
        {
            int MemoryChe = rnd.Next(0, 10);
            if (MemoryChe == 7)
            {
                Console.WriteLine("Check debe reiniciarse, ya que su memoria ha llegado a 7\n");
                return MemoryChe;
            }
            else { return 0; }
        }
        public override void Restart(int MemoryChe)
        {
            if (MemoryChe == 7)
            {
                Console.WriteLine("Diga la máquina que desea reiniciar: r -> Reception, s -> Storage, a -> Assembly, c -> Check, p -> Packing\n");
                respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "c")
                {
                    Console.WriteLine("Check se ha reiniciado y su memoria vuelve a 0\n");
                    MemoryChe = 0;
                }
                else { }
            }
            else { }
        }
        public override void Off()
        {
            Console.WriteLine("Check se apagó\n");
            MemoryChe = 0;
        }
    }
}
