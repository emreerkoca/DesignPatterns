using DependencyInversionSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldenGun goldenGun = new GoldenGun();
            SerialGun serialGun = new SerialGun();

            goldenGun.Fire();
            serialGun.Fire();
        }
    }
}
