using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {

        // Entidades Externas 

        private String monitor;
        private String teclado;
        private String mause;
        private String immpresora;
        private String scaner;




        // Entidades Internas

        private int RAM;
        private int almacenamiento;
        private String microprocesador;
        private int placamadre;
        private string tarjetadevideo;

        public string Monitor { get => monitor; set => monitor = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mause { get => mause; set => mause = value; }
        public string Immpresora { get => immpresora; set => immpresora = value; }
        public string Scaner { get => scaner; set => scaner = value; }
        public int RAM1 { get => RAM; set => RAM = value; }
        public int Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public string Microprocesador { get => microprocesador; set => microprocesador = value; }
        public int Placamadre { get => placamadre; set => placamadre = value; }
        public string Tarjetadevideo { get => tarjetadevideo; set => tarjetadevideo = value; }

    }

}
