using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Reception recep = new Reception(0);
            Storage stor = new Storage(0);
            Assembly assem = new Assembly(0);
            Check chec = new Check(0);
            Packing packy = new Packing(0);
            
            Console.WriteLine("El día acaba de comenzar\n");
            System.Threading.Thread.Sleep(1000);

            recep.On();
            System.Threading.Thread.Sleep(1000);
            stor.On();
            System.Threading.Thread.Sleep(1000);
            assem.On();
            System.Threading.Thread.Sleep(1000);
            chec.On();
            System.Threading.Thread.Sleep(1000);
            packy.On();
            System.Threading.Thread.Sleep(1000);

            int veces = 15;
            while (veces > 0)
            {
                recep.Restart(recep.Memory());
                System.Threading.Thread.Sleep(100);
                stor.Restart(stor.Memory());
                System.Threading.Thread.Sleep(100);
                assem.Restart(assem.Memory());
                System.Threading.Thread.Sleep(100);
                chec.Restart(chec.Memory());
                System.Threading.Thread.Sleep(100);
                packy.Restart(packy.Memory());
                System.Threading.Thread.Sleep(100);
                veces--;
            }

            recep.Off();
            System.Threading.Thread.Sleep(1000);
            stor.Off();
            System.Threading.Thread.Sleep(1000);
            assem.Off();
            System.Threading.Thread.Sleep(1000);
            chec.Off();
            System.Threading.Thread.Sleep(1000);
            packy.Off();
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("El día ha finalizado\n");
            Console.ReadLine();
        }
    }
}
