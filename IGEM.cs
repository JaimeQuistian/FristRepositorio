﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class IGEM:Alumno
    {
        char seccionGlobal;
        //Constructores
        public IGEM(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public IGEM(char seccion, string nombreAlumnoHerencia, string apellidoPrimeroHerencia, string apellidoSegundoHerencia, DateTime fechaRegistroHerencia,
            DateTime fechaNacimientoHerencia)
            : base(nombreAlumnoHerencia, apellidoPrimeroHerencia, apellidoSegundoHerencia, fechaRegistroHerencia, fechaNacimientoHerencia)
        {
            this.seccionGlobal = seccion;
        }
        public IGEM()
        {

        }
        public override void InformacionDePago()
        {
            base.InformacionDePago();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Parte de código modificada");
            Console.WriteLine("\nIngienería en Gestión Empresarial");
        }
    }
}
