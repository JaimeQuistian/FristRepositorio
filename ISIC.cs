﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class ISIC : Alumno 
    //Operador de Herencia ":"
    {
        char seccionGlobal;
        //Constructores
        public ISIC(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public ISIC(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, string apellidoSegundoHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, apellidoSegundoHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public ISIC()
        {

        }

        //sobreescritura
        public override void InformacionDePago()
        {
            base.InformacionDePago();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sección {0}", seccionGlobal);
            Console.WriteLine("Parte de código modificada");
            Console.WriteLine("Ingienería en Sistemas Computacionales");
        }
    }
}
