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

            //Console.WindowHeight = 28;
            //Console.WindowWidth = 40;

            #region OldCodeV2.0
            ////1. Instanciar un obejeto
            //Alumno alumno1 = new Alumno("Daniela Ailyn", "Rodriguez", "Díaz", Convert.ToDateTime("25-06-2021"),
            //    Convert.ToDateTime("25-06-2003"), "Colonia Centro", "Ing en Sistemas");

            //Alumno alumno2 = new Alumno("Amador", "Rivera", "Martinez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("04-01-2004"),
            //    "Reyes G", "Ing en Sistemas");

            //Alumno alumno3 = new Alumno("Ezequiel", "Sandoval", "Martinez", Convert.ToDateTime("25-06-2021"),
            //    Convert.ToDateTime("07-12-2003"), "Colonia Emiliano Zapata", "Ing en Sistemas");

            //Alumno alumno4 = new Alumno("Alfonso", "Vargas", "Hernandez", Convert.ToDateTime("25-06-2021"),
            //    Convert.ToDateTime("18-09-2003"), "Colonia Francisco Villa", "Ing en Sistemas");

            //Alumno alumno5 = new Alumno("Yolanda Elizabeth", "Zapata", "Gonzalez", Convert.ToDateTime("25-06-2021"),
            //    Convert.ToDateTime("25-06-2003"), "Colonia Emiliano Zapata", "Ing en Sistemas");

            //Alumno alumno6 = new Alumno("Sonia", "Huerta", "Carrillo", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("18-11-2003"),
            //    "Colonia Francisco I Madero", "Ing en Sistemas");

            //Alumno alumno7 = new Alumno("Adrian", "Ortiz", "Quistian", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("15-10-2003"),
            //    "Colonia Fco. Villa", "Ing en Sistemas");



            ////2. Madar llamar algun miembro
            ////Console.WriteLine("DATOS INGRESADOS");
            ////Console.WriteLine(alumno1.EdadAlumnoCalculo1());
            ////Console.WriteLine(alumno2.EdadAlumnoCalculo1());
            ////Console.WriteLine(alumno3.EdadAlumnoCalculo1());
            ////Console.WriteLine(alumno4.EdadAlumnoCalculo1());
            ////Console.WriteLine(alumno5.EdadAlumnoCalculo1());
            ////Console.WriteLine(alumno6.EdadAlumnoCalculo1());
            ////Console.WriteLine(alumno7.EdadAlumnoCalculo1());

            ////alumno1.CalcularInscripcion(90);
            ////if (alumno1.CalcularInscripcion(90) == 0)
            ////{
            ////    Console.WriteLine("Lo sentimos pero su promedio es menor a la cantidad aceptada");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("DATOS INGRESADOS");
            ////    Console.WriteLine(alumno1.InformacionDePago(90));
            ////    Console.WriteLine(alumno1.InformacionDePago(90));
            ////}

            //Console.WriteLine("\tDATOS INGRESADOS\n");
            //Console.WriteLine(alumno1.InformacionDePago(90));
            //Console.WriteLine(alumno2.InformacionDePago(75));
            //Console.WriteLine(alumno3.InformacionDePago());
            #endregion

            byte opcion;
            ConsoleKeyInfo actualizacionDatos;
            double promedioAlumno;
            ConsoleKeyInfo opcionDatos;
            Console.WriteLine("InscribeTEC");
            Console.WriteLine("Opciones:\n\t1. Inscribir Ususario\n\t2.Salir");
            opcion = byte.Parse(Console.ReadLine());
            
            while (opcion == 1)
            {
                ConsoleKeyInfo carreraElegida;
                Console.WriteLine("¿A que carrera se inscribirá el alumno?\n\n" +
                    "1. Ingieneria en Sistemas Computacionales 'ISIC'\t 2. Ingieneria Industrial 'INID'\n" +
                    "3. Inieneria en Gestion Empresarial 'IGEM'   \t        4. Ingieneria en Logistica 'ILOG'");
                carreraElegida = Console.ReadKey();

                #region Carera_ISIC
                if (carreraElegida.Key == ConsoleKey.D1)
                {
                    string nombre, apellidoPaterno, apellidoMaterno;
                    DateTime fechaNacimiento;
                    char grupo;
                    Console.WriteLine("\nIngresa el nombre(s) del alumno: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el primer aplellido del alumno: ");
                    apellidoPaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa el segundo aplellido del alumno: ");
                    apellidoMaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de nacimiento del alumno: ");
                    fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Ingresa el grupo donde se registrará al alumno: ");
                    grupo = Convert.ToChar(Console.ReadLine());

                    ISIC objISIC = new ISIC(grupo, nombre, apellidoPaterno, apellidoMaterno, DateTime.Now, fechaNacimiento);
                    objISIC.InformacionDePago();

                    Console.WriteLine("Desea modificar un dato\nS. SI\tN. No");
                    opcionDatos = Console.ReadKey();
                    while (opcionDatos.Key == ConsoleKey.S)
                    {
                        if (opcionDatos.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("\nSeleccione una de las siguientes opciones:\nA. Actualizar la fecha de nacimiento\n" +
                            "B. Calcular pago inscripción\nC. Actualizar edad del Alumno");
                            actualizacionDatos = Console.ReadKey();
                            if (actualizacionDatos.Key == ConsoleKey.A)
                            {
                                Console.WriteLine("\nActualice la fecha de nacimiento correcta del alumno {0}", nombre);
                                objISIC.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("\nDatos actualizados\n"); objISIC.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.B)
                            {
                                Console.WriteLine("\nActualice el promedio correcto del alumno {0}", nombre);
                                objISIC.CalcularInscripcion(promedioAlumno = Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objISIC.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.C)
                            {
                                Console.WriteLine("\nActualice la fecha de naciemiento correcta del alumno {0}", nombre);
                                objISIC.EdadAlumnoCalculo2(fechaNacimiento = Convert.ToDateTime(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objISIC.InformacionDePago();
                            }
                        }
                        Console.WriteLine("¿Desea modificar otro dato?\nS. SI\tN. No");
                        opcionDatos = Console.ReadKey();
                    }
                }
                #endregion

                #region Carrera_INID
                if (carreraElegida.Key == ConsoleKey.D2)
                {
                    string nombre, apellidoPaterno, apellidoMaterno;
                    DateTime fechaNacimiento;
                    char grupo;
                    Console.WriteLine("\nIngresa el nombre(s) del alumno: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el primer aplellido del alumno: ");
                    apellidoPaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa el segundo aplellido del alumno: ");
                    apellidoMaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de nacimiento del alumno: ");
                    fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Ingresa el grupo donde se registrará al alumno: ");
                    grupo = Convert.ToChar(Console.ReadLine());

                    INID objINID = new INID(grupo, nombre, apellidoPaterno, apellidoMaterno, DateTime.Now, fechaNacimiento);
                    objINID.InformacionDePago();

                    Console.WriteLine("Desea modificar un dato\nS. SI\tN. No");
                    opcionDatos = Console.ReadKey();
                    while (opcionDatos.Key == ConsoleKey.S)
                    {
                        if (opcionDatos.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("\nSeleccione una de las siguientes opciones:\nA. Actualizar la fecha de nacimiento\n" +
                            "B. Calcular pago inscripción\nC. Actualizar edad del Alumno");
                            actualizacionDatos = Console.ReadKey();
                            if (actualizacionDatos.Key == ConsoleKey.A)
                            {
                                Console.WriteLine("\nActualice la fecha de nacimiento correcta del alumno {0}", nombre);
                                objINID.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("\nDatos actualizados\n"); objINID.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.B)
                            {
                                Console.WriteLine("\nActualice el promedio correcto del alumno {0}", nombre);
                                objINID.CalcularInscripcion(promedioAlumno = Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objINID.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.C)
                            {
                                Console.WriteLine("\nActualice la fecha de naciemiento correcta del alumno {0}", nombre);
                                objINID.EdadAlumnoCalculo2(fechaNacimiento = Convert.ToDateTime(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objINID.InformacionDePago();
                            }
                        }
                        Console.WriteLine("¿Desea modificar otro dato?\nS. SI\tN. No");
                        opcionDatos = Console.ReadKey();
                    }
                }
                #endregion

                #region Carrera_IGEM
                if (carreraElegida.Key == ConsoleKey.D3)
                {
                    string nombre, apellidoPaterno, apellidoMaterno;
                    DateTime fechaNacimiento;
                    char grupo;
                    Console.WriteLine("\nIngresa el nombre(s) del alumno: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el primer aplellido del alumno: ");
                    apellidoPaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa el segundo aplellido del alumno: ");
                    apellidoMaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de nacimiento del alumno: ");
                    fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Ingresa el grupo donde se registrará al alumno: ");
                    grupo = Convert.ToChar(Console.ReadLine());

                    IGEM objIGEM = new IGEM(grupo, nombre, apellidoPaterno, apellidoMaterno, DateTime.Now, fechaNacimiento);
                    objIGEM.InformacionDePago();

                    Console.WriteLine("Desea modificar un dato\nS. SI\tN. No");
                    opcionDatos = Console.ReadKey();
                    while (opcionDatos.Key == ConsoleKey.S)
                    {
                        if (opcionDatos.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("\nSeleccione una de las siguientes opciones:\nA. Actualizar la fecha de nacimiento\n" +
                            "B. Calcular pago inscripción\nC. Actualizar edad del Alumno");
                            actualizacionDatos = Console.ReadKey();
                            if (actualizacionDatos.Key == ConsoleKey.A)
                            {
                                Console.WriteLine("\nActualice la fecha de nacimiento correcta del alumno {0}", nombre);
                                objIGEM.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("\nDatos actualizados\n"); objIGEM.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.B)
                            {
                                Console.WriteLine("\nActualice el promedio correcto del alumno {0}", nombre);
                                objIGEM.CalcularInscripcion(promedioAlumno = Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objIGEM.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.C)
                            {
                                Console.WriteLine("\nActualice la fecha de naciemiento correcta del alumno {0}", nombre);
                                objIGEM.EdadAlumnoCalculo2(fechaNacimiento = Convert.ToDateTime(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objIGEM.InformacionDePago();
                            }
                        }
                        Console.WriteLine("¿Desea modificar otro dato?\nS. SI\tN. No");
                        opcionDatos = Console.ReadKey();
                    }
                }
                #endregion

                #region Carrera_ILOG
                if (carreraElegida.Key == ConsoleKey.D4)
                {
                    string nombre, apellidoPaterno, apellidoMaterno;
                    DateTime fechaNacimiento;
                    char grupo;
                    Console.WriteLine("\nIngresa el nombre(s) del alumno: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el primer aplellido del alumno: ");
                    apellidoPaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa el segundo aplellido del alumno: ");
                    apellidoMaterno = Console.ReadLine();
                    Console.WriteLine("Ingresa la fecha de nacimiento del alumno: ");
                    fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Ingresa el grupo donde se registrará al alumno: ");
                    grupo = Convert.ToChar(Console.ReadLine());

                    ILOG objILOG = new ILOG(grupo, nombre, apellidoPaterno, apellidoMaterno, DateTime.Now, fechaNacimiento);
                    objILOG.InformacionDePago();

                    Console.WriteLine("Desea modificar un dato\nS. SI\tN. No");
                    opcionDatos = Console.ReadKey();
                    while (opcionDatos.Key == ConsoleKey.S)
                    {
                        if (opcionDatos.Key == ConsoleKey.S)
                        {
                            Console.WriteLine("\nSeleccione una de las siguientes opciones:\nA. Actualizar la fecha de nacimiento\n" +
                            "B. Calcular pago inscripción\nC. Actualizar edad del Alumno");
                            actualizacionDatos = Console.ReadKey();
                            if (actualizacionDatos.Key == ConsoleKey.A)
                            {
                                Console.WriteLine("\nActualice la fecha de nacimiento correcta del alumno {0}", nombre);
                                objILOG.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("\nDatos actualizados\n"); objILOG.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.B)
                            {
                                Console.WriteLine("\nActualice el promedio correcto del alumno {0}", nombre);
                                objILOG.CalcularInscripcion(promedioAlumno = Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objILOG.InformacionDePago();
                            }
                            if (actualizacionDatos.Key == ConsoleKey.C)
                            {
                                Console.WriteLine("\nActualice la fecha de naciemiento correcta del alumno {0}", nombre);
                                objILOG.EdadAlumnoCalculo2(fechaNacimiento = Convert.ToDateTime(Console.ReadLine()));
                                Console.WriteLine("\nDatos actualizados\n{0}"); objILOG.InformacionDePago();
                            }
                        }
                        Console.WriteLine("¿Desea modificar otro dato?\nS. SI\tN. No");
                        opcionDatos = Console.ReadKey();
                    }
                }
                #endregion

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nInscribeTEC");
                Console.WriteLine("Opciones:\n\t1. Inscribir Ususario\n\t2.Salir");
                opcion = byte.Parse(Console.ReadLine());
            }

            //Crear obejeto de la clase heredada ISIC
            
            Console.ReadKey();
        }
    }
}