using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Mvc.Services
{

    public interface ICalculadora
    {
        int Sumar(int n1, int n2);        
        int Restar(int n1, int n2);
        int Multiplicar(int n1, int n2);


    }
}