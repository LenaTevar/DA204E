using System;
using System.Collections.Generic;
using System.Text;

namespace VT2021_DA204E_18052_A1._1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            myPet.GetInput();
            myPet.ToConsole();
        }
    }
}
