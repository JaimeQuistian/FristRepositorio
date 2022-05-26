using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class ISIC : Alumno 
    //Operador de Herencia ":"
    {
        //Constructor
        public ISIC(string nombreAlumnoherencia, string apellidoPrimeroHerencia, string apellidoSegundoHerencia, 
            DateTime fechaRegistroHerencia, DateTime fechaNacimientoHerencia) 
            :base(nombreAlumnoherencia, apellidoPrimeroHerencia, apellidoSegundoHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            
        }
        //sobreescribir
        public override string InformacionDePago()
        {
            Console.WriteLine("\nIngienería en Sistemas Computacionales");
            return base.InformacionDePago();
        }

    }
}
