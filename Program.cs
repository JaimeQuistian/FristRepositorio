using System;

namespace ClasesEjemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OldCode
            //  //Instanciar (crear) un objeto
            //  //tipoDeClase nombreObjeto = new tipoDeClase();  |  El "= new" es un operador de instanciación
            //  Calculadora operacion = new Calculadora(); //"suma" es el nombre del objeto
            //  //Acceder a los miembros  nombreObjeto.Propiedad
            //  int resultadoDevuelto = operacion.SumaNumeroUno; //Este objeto regresa el valor que esta en la clase y como es de tipo
            //                                              //lectura se guarda en una variable
            //  Console.WriteLine(resultadoDevuelto); //Mostrar en consola el valor de la variable de la clase


            //  //Propiedades del objeto suma de la segunda variable "sumaNumeroDos"
            //  int resultadoDevuetoDos = operacion.SumaNumeroDos;
            //  Console.WriteLine("El primer valor guardado dentro de la clase es: {0}",resultadoDevuetoDos);

            //  operacion.SumaNumeroDos = 90;    //Asignacion de un nuevo valor a la propiedad SumaNumeroDos
            //  resultadoDevuetoDos = operacion.SumaNumeroDos;
            //  Console.WriteLine("El nuevo valor guardado dentro de la clase es: {0}", resultadoDevuetoDos);

            //  Console.ReadKey();
            //  Console.Clear();

            //  //-----------------------------------------------------------------------------------------------------------------

            //  //-----------------------------------Objetos de la clase alumno------------------------------------------------------

            //  Alumno objetoUno = new Alumno("Adrián Pedro", "Ortiz", DateTime.Now);      //Se manda a llamar el constructor
            //  //objetoUno.NombreAlumno = "Ezequiel";   //El usuario ya no puede cambiar el nombre y tiene una propiedad solo de lectura
            //  Console.WriteLine("El alumno es: {0}",objetoUno.NombreAlumno);
            //  objetoUno.FechaDeNacimiento = Convert.ToDateTime("11-03-2003");
            //  Console.WriteLine(/*"Tiene {0} años",*/objetoUno.EdadAlumnoCalculo1());

            ///*--------------------------------------------------------- 
            //  //Matricula
            //  //Console.WriteLine(objetoUno.MatriculaAlumno("003"));
            //----------------------------------------------------------*/

            //  Alumno objetoDos = new Alumno("Yolanda Elizabeth", "Zapata",Convert.ToDateTime("04-04-2020"));
            //  //objetoDos.NombreAlumno = "Yolanda";
            //  Console.WriteLine("\nEl alumno es: {0}", objetoDos.NombreAlumno);
            //  Console.WriteLine(objetoDos.EdadAlumnoCalculo1());
            //  /*objetoDos.FechaDeNacimiento = Convert.ToDateTime("26-09-2003 07:30:21");
            //  if (objetoDos.EdadAlumnoCalculo()==0)
            //  {
            //      Console.WriteLine("Edad No asignada");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Tiene {0} años", objetoDos.EdadAlumnoCalculo()); //Mandamos a llamar el metodo "EdadAlumnoCalculo"
            //  }*/


            //  /*--------------------------------------------------------- 
            //  //Matricula
            //  //Console.WriteLine(objetoDos.MatriculaAlumno("001"));
            //  ----------------------------------------------------------*/


            //  Alumno objetoTres = new Alumno("Evelin Michel", "Chavez", Convert.ToDateTime("04-04-2021"));                                     
            //  //objetoTres.NombreAlumno = "Evelin";
            //  Console.WriteLine("\nEl alumno es: {0}", objetoTres.NombreAlumno);
            //  //objetoTres.FechaDeNacimiento = Convert.ToDateTime("13-02-2002");
            //  Console.WriteLine(objetoTres.EdadAlumnoCalculo2(Convert.ToDateTime("13-02-2002"))); //Mandamos a llmar al metodo "EdadAlumnoCalculo1" para que muestre el nuevo cambio
            //                                            //    |    Parametro de entrada     |
            //  Console.WriteLine(objetoTres.FechaDeNacimiento);

            //  /*--------------------------------------------------------- 
            //  //Matricula
            //  //Console.WriteLine(objetoTres.MatriculaAlumno("002"));
            //  ----------------------------------------------------------*/

            //  //---------------------------------------------------------------------------------
            #endregion

            Console.WindowHeight = 44;
            Console.WindowWidth = 52;

            //1. Instanciar un obejeto
            Alumno alumno1 = new Alumno("Daniela Ailyn", "Rodriguez", "Díaz", Convert.ToDateTime("25-06-2021"), 
                Convert.ToDateTime("25-06-2003"), "Colonia Centro", "Ing en Sistemas");

            Alumno alumno2 = new Alumno("Amador", "Rivera", "Martinez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("04-01-2004"),
                "Reyes G", "Ing en Sistemas");
            
            Alumno alumno3 = new Alumno("Ezequiel", "Sandoval", "Martinez", Convert.ToDateTime("25-06-2021"), 
                Convert.ToDateTime("07-12-2003"), "Colonia Emiliano Zapata", "Ing en Sistemas");
            
            Alumno alumno4 = new Alumno("Alfonso", "Vargas", "Hernandez", Convert.ToDateTime("25-06-2021"), 
                Convert.ToDateTime("18-09-2003"), "Colonia Francisco Villa", "Ing en Sistemas");
            
            Alumno alumno5 = new Alumno("Yolanda Elizabeth", "Zapata", "Gonzalez", Convert.ToDateTime("25-06-2021"), 
                Convert.ToDateTime("25-06-2003"), "Colonia Emiliano Zapata", "Ing en Sistemas");
            
            Alumno alumno6 = new Alumno("Sonia", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("18-11-2003"),
                "Colonia Francisco I Madero", "Ing en Sistemas");

            Alumno alumno7 = new Alumno("Joseph Moises", "Castillo", "Silva", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("15-10-2003"),
                "Ejd Santa Teresa","Ing en Logistica");


            //2. Madar llamar algun miembro
            Console.WriteLine("DATOS INGRESADOS");
            Console.WriteLine(alumno1.EdadAlumnoCalculo1());
            Console.WriteLine(alumno2.EdadAlumnoCalculo1());
            Console.WriteLine(alumno3.EdadAlumnoCalculo1());
            Console.WriteLine(alumno4.EdadAlumnoCalculo1());
            Console.WriteLine(alumno5.EdadAlumnoCalculo1());
            Console.WriteLine(alumno6.EdadAlumnoCalculo1());
            Console.WriteLine(alumno7.EdadAlumnoCalculo1());
            
            Console.ReadKey();

            //Terminar el codigo
        }
    }
}