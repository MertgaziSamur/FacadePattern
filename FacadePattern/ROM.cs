using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class ROM
    {
        private int size;
        public ROM(int size)
        {
            this.size = size;
        }
        public byte[] getOsKernelImage()
        {
            Console.WriteLine("ROM: Loading the image of OS kernel.");
            byte[] kernelImage = new byte[2 * 1024 * 1024];

            //...

            return kernelImage;
        }
    }
}
