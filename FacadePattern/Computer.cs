using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{

    // This class Facade 
    public class Computer
    {
        private CPU cpu;
        private RAM ram;
        private HardDrive hd;
        private Display display;

        public Computer()
        {
            cpu = new CPU();
            ram = new RAM();
            hd = new HardDrive();
            display = new Display();

        }
        public void start()
        {
            cpu.start();
            hd.start();
            bool kernelLoaded = ram.loadOsKernelImage();
            while (!kernelLoaded)
            {
                ram.fixIt();
                kernelLoaded = ram.loadOsKernelImage();
            }

            bool osLoaded = ram.loadOs();
            while (!osLoaded)
            {
                ram.fixIt();
                osLoaded = ram.loadOs();
            }
            ram.loadDrivers();
            ram.startServices();
            display.start();
            Console.WriteLine("Computer has started");
        }
    }
}
