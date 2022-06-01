using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class ILOG:Alumno
    {
        char seccionGlobal;
        //Constructores
        public ILOG(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public ILOG(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, string apellidoSegundoHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, apellidoSegundoHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public ILOG()
        {

        }
        //sobreescritura
        public override void InformacionDePago()
        {
            base.InformacionDePago();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Parte de código modificada");
            Console.WriteLine("Ingienería en Logistica");
        }
    }
}
