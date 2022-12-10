using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class RAM
    {
        private BIOS bios;
        private bool kernelLoaded = false;
        private bool osLoaded;
        private Random rnd;

        public RAM()
        {
            bios = new BIOS();
            rnd = new Random();
            double random = rnd.NextDouble();
            if (random < 0.8)
            {
                kernelLoaded = true;
                osLoaded = true;
            }
        }
        public void fixIt()
        {
            Console.WriteLine("Fixing kernel and OS!");
            kernelLoaded = true;
            osLoaded = true;
        }
        public void loadDrivers()
        {
            Console.WriteLine("Drivers Loaded!");
        }
        public bool loadOs()
        {
            if (osLoaded)
            {
                Console.WriteLine("OS has been loaded successfully");
            }
            else
            {
                Console.WriteLine("OS loading has been failed");
            }
            return osLoaded;
        }
        public bool loadOsKernelImage()
        {
            Console.WriteLine("RAM: Loading the image of OS kernel.");
            if (kernelLoaded)
            {
                bios.start();
                Console.WriteLine("RAM: Image of OS kernel has been loaded.");
            }
            else
            {
                Console.WriteLine("RAM: Image of OS kernel has been loaded.");
            }
            return osLoaded;
        }
        public void startServices()
        {
            Console.WriteLine("Services Loaded");
        }
    }
}
