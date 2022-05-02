using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class Calculadora
    {
        //tipoDato identificador (nombreVariable)
        //string | bool | int | double | float (1.f)
        //private, public //Key works
        int sumaNumeroUno = 5; 
        int sumaNumeroDos=10;    //A estas variables (Miembros) se le conocen como CAMPOS

        //Miembro de tipo Propiedad
        //public tipoDeDato nombrePropiedad {}
        public int SumaNumeroUno //SumaNumeroUno tiene el mimo nombre pero en PascalCase
        {
            //get(obtener | lectura) | set(poner | escritura)      | key works
            get
            {
                return sumaNumeroUno; //return regresa una variable
            }
        }
        public int SumaNumeroDos
        {
            get
            {
                return sumaNumeroDos;
            }
            set
            {
                sumaNumeroDos = value; //value sustitulle todo el valor que encuentre despues de un =
            }
        }


        int multiplicaionValorUno = 10;
        int multiplicaionValorDos = 1;
        public int MultiplicacionValorUno
        {
            get
            {
                return multiplicaionValorUno;
            }
        }
        public int MultiplicacionValorDos
        {
            get
            {
                return multiplicaionValorDos;
            }
            set
            {
                multiplicaionValorDos = value;
            }
        }

    }
}
