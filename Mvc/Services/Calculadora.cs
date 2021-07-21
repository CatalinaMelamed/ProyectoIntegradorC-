using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc.Services.ServicioCalculadora;
namespace Mvc.Services
{
    public class Calculadora : ICalculadora
    {
        
        public  int Sumar(int n1, int n2)
        {
            int result = new Calculator().Add(n1, n2);
            return result;
        }
        

        public int Multiplicar(int n1, int n2)
        {
            int result = new Calculator().Multiply(n1, n2);
            return result;
        }

        public int Restar(int n1, int n2)
        {
            int result = new Calculator().Subtract(n1, n2);
            return result;
        }
    }
}