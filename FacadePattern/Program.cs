using System;

namespace FacadePattern
{
    class Program
    {
        // This class client. Can be thought of as the start button.
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.start();
        }
    }
}
