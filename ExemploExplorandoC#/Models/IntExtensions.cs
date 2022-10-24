using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorandoC_.Models
{
    public static class IntExtensions
    {
        public static bool VerificarPar(this int numero){

            return numero % 2 == 0;
        }
    }
}