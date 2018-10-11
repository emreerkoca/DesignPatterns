using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionExample.Models
{
    public class SerialGun : IGun
    {
        public void Fire()
        {
            Console.WriteLine("Serial gun fired!");
        }
    }
}
