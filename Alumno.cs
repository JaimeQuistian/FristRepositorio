using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEjemplo1
{
    class Alumno
    {
        //---------------------------------------------------------Campos--------------------------------------------------------------
        
        int numeroMaterias, numeroMateriasNoAcreditadas;
        string nombreAlumno = string.Empty;
        string apellidoPrimero, apellidoSegundo, carreraAlumno, contrasenaAlumno, curpAlumno, nombreInstitucion, domicilioAlumno, matricula;
        DateTime fechaDeNacimiento, fechaDeRegistro;


        //-------------------------------------------------Miembro de tipo constante----------------------------------------------------

        const string fechaCreacionInstitucion = "01-08-2008";
        const string numeroTecnologico = "100";

        //----------------------------------------------Miembro de tipo constructor----------------------------------------------------

        //Tipo de acceso | nombre de la clase (entrada) {}
        //Los constructores siempre son de tipo public
       public Alumno (string nombreAlumnoEntrada, string apellidoPrimeroEntrada, string apellidoSegundoEntrada, DateTime fechaRegistroEntrada, 
           DateTime fechaDeNacimientoEntrada, string domicilioAlumnoEntrada, string carreraAlumnoEntrada /*Los valores de entrada*/)
        {                    //Hay declaraciones Especificas ";" e Implicitas "El constructor"
            nombreAlumno = nombreAlumnoEntrada;
            apellidoPrimero = apellidoPrimeroEntrada;
            fechaDeRegistro = fechaRegistroEntrada;
            matricula = (fechaDeRegistro.Year + "" + numeroTecnologico).Substring(2,5)+""+Folio.numeroFolio; // +""+ = Concatenar
            Folio.numeroFolio += 1;
            fechaDeNacimiento = fechaDeNacimientoEntrada;
            domicilioAlumno = domicilioAlumnoEntrada;
            apellidoSegundo = apellidoSegundoEntrada;
            curpAlumno = ((apellidoPrimero).Substring(0,2)) +""+ ((apellidoSegundo).Substring(0,1)) +""+ ((nombreAlumno).Substring(0,1))
                +""+ ((fechaDeNacimiento.Year) + ""+ (Convert.ToString(fechaDeNacimiento).Substring(3,2)) +""+ 
                (Convert.ToString(fechaDeNacimiento).Substring(0,2))).Substring(2,6);
            carreraAlumno = carreraAlumnoEntrada;

            if (Folio.numeroFolio >=1 && Folio.numeroFolio <=9)
            {
                matricula = (fechaDeRegistro.Year + "" + numeroTecnologico).Substring(2, 5) + "000" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 10 && Folio.numeroFolio <= 99)
            {
                matricula = (fechaDeRegistro.Year + "" + numeroTecnologico).Substring(2, 5) + "00" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 100 && Folio.numeroFolio <= 999)
            {
                matricula = (fechaDeRegistro.Year + "" + numeroTecnologico).Substring(2, 5) + "0" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 1000 && Folio.numeroFolio <= 9999)
            {
                matricula = (fechaDeRegistro.Year + "" + numeroTecnologico).Substring(2, 5) + "" + Folio.numeroFolio;
            }

        }

        #region propiedades
        //--------------------------------------Miembros de tipo propiedad (proteger algun campo)---------------------------------------
        public string NombreAlumno
        {
            get
            {
                if (nombreAlumno != string.Empty)
                {
                    return nombreAlumno;
                }
                else
                {
                    return "Nombre no asignado";
                }
            }
        }
        #endregion
        //------------------------------------------------------------Metodos------------------------------------------------------------

        //Miembro de tipo "metodo"

        //Tipo Acceso | Tipo de dato | NombreMetodo  (Opcional: dominio | entrada) {}
        //Tipo acceso: public - private - protected - internal
        //Tipo de dato: int, float, string, char, double.......
        #region metodoEdadAlumnoCalculo
        //Metodo
        public int EdadAlumnoCalculo (/*Metodo sin entradas declaradas*/)
        {
            //Calcular la edad
            int edad;
            //Validad que la fecha de nacimiento se haya asignado por el usuario
            if (fechaDeNacimiento.Year < 1000)
            {
                edad = 0;
            }
            else
            {
                edad = ((DateTime.Now - fechaDeNacimiento).Days) / 365; //.Day Dias
            }

            return edad;
        }

        //Los metodos normalmente son public
        #endregion
        //-------------------------------------------------Miembro de tipo metodo---------------------------------------------------------
        //Cambiamos el rango de la función
        public string EdadAlumnoCalculo1 (/*Metodo sin entradas declaradas*/)
        {
            int edad;
            string valorDeRetorno;
            if (fechaDeNacimiento.Year < 1960)
            {
                valorDeRetorno=string.Format("La edad no ha sido asignada, favor de asignar la edad al alumno: {0} {1} {2}", nombreAlumno,
                    apellidoPrimero, apellidoSegundo);
            }
            else
            {
                edad = ((DateTime.Now - fechaDeNacimiento).Days) / 365; //.Day Dias
                valorDeRetorno = String.Format("Nombre alumno/a: {0} {1} {5}\nMatricula {3}\nEdad: {2} años\nCurp: {6}\nEstá inscrito en" +
                    " la carrera de: {7}\n", nombreAlumno, apellidoPrimero, edad, matricula, domicilioAlumno, apellidoSegundo, 
                    curpAlumno,carreraAlumno);
            }
            return valorDeRetorno;
        }

        #region metodoEdadAlumnoCalculo2
        //Metodo con valores de entrada (dominio)
        public string EdadAlumnoCalculo2(DateTime fechaNacimientoEntrada)
        {
            int edad;
            string valorDeRetorno;
            fechaDeNacimiento = fechaNacimientoEntrada;
            if (fechaNacimientoEntrada.Year < 1960)
            {
                valorDeRetorno = string.Format("La edad no ha sido asignada, favor de asignar la edad al alumno: {0}", nombreAlumno);
            }
            else
            {
                edad = ((DateTime.Now - fechaNacimientoEntrada).Days) / 365; //.Day Dias
                valorDeRetorno = String.Format("El alumno: {0}\nTiene la edad de {1} años", nombreAlumno, edad);
            }
            return valorDeRetorno;
        }
        #endregion

        #region Mi intento de calcular la matricula
        /*                                Mi intento de calcular la matricula
        //Metodo MatriculaAlumno
        public string MatriculaAlumno (string alumnoRegistrado)
        {
            string matriculaAlumno = string.Format("La matricula del alumno es: {0}{1}{2}", Convert.ToString(fechaDeRegistro), numeroTecnologico, alumnoRegistrado);
            return matriculaAlumno;
        }
        */

        /*
        - Cree un campo fechaDeRegistro para guardar el año en que se enscribió el alumno
        - Cree un campo constante numeroTecnologico para guardar el número del Tec San Pedro
        - Dentro del constructor asigne la entrada fechaRegistroEntrada para guardar en la variable fechaRegistro la fecha en que se 
          registró el alumno
        - Cree un metodo para calcular la matricula del alumno
        - Dentro del metodo asigné una variable de tipo string que guardará todos los datos para crear la matricula del alumno en base
          a los datos que nos dieron (año de inscripción | número del Tec | número del alumno registrado)
        */
        #endregion
    }
}