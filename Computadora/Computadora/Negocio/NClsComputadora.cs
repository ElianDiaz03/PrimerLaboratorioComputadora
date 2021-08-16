using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
        public String Encender (ClsComputadora computadora)
        {


            return " El monitor de la computadora " + computadora.Monitor + " Con una RAM de " + computadora.RAM1 + " Esta Encendida ";

       

    }
       public String Apagar (ClsComputadora computadora)
       {

            return " El mouse de la computadora " + computadora.Mause + " Con el monitor de " + computadora.Monitor + " Estan apagandose ";

            
       }
        public String Reiniciar (ClsComputadora computadora)
        {


            return " La RAM de la computadora " + computadora.RAM1 + " Con la placa madre de " + computadora.Placamadre + " Estan Reiniciandose " ; 
       
        }
        public String Mouse(ClsComputadora computadora)

        {
            return " El mouse " + computadora.Mause + " No está puesto ";


        }

    }
}

