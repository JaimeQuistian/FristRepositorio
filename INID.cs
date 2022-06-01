using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class INID:Alumno
    {
        char seccionGlobal;
        //Constructores
        public INID(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public INID(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, string apellidoSegundoHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, apellidoSegundoHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public INID()
        {

        }
        public override void InformacionDePago()
        {
            base.InformacionDePago();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Parte de código modificada");
            Console.WriteLine("\nIngienería Empresarial");
            
        }
    }
}
