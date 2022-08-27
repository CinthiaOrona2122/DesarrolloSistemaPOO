namespace EjercicioAmigos
{
    /*
     Implementar en C# un programa que maneje un arreglo de estructuras para almacenar las fechas de cumpleaños 
    de n cantidad de amigos. Los datos a almacenar sobre cada amigo son nombre, día, mes y año. 
    El programa debe indicarnos cuántos de nuestros amigos cumplen años en un mes determinado introducidos por 
    teclado.

    A la estructura de los cumpleaños de amigos, agregarle:
    *Un metodo que permita setearle la fecha de nacimiento.
    *Un metodo que devuelva si es mayor de edad.
    *Un metodo que devuelva el nombre y el apellido preparado para mostrarse con writeline.
    *Un metodo que devuelva cuántos años tiene.
    *Un metodo que devuelva en un string el nombre, apellido, la fecha de nacimiento, edad y si es mayor de edad o no,
    para ser usado con writeline.
    Modificar el prog que usa array para que haga uso de todos estos nuevos metodos.
     */

    internal class Program
    {
        struct Fecha
        {
            public int dia;
            public int mes;
            public int anio;

            public Fecha(int d, int m, int a)
            {
                dia = d;
                mes = m;
                anio = a;
            }

            public void setearFecha(int d, int m, int a)
            {
                dia = d;
                mes = m;
                anio = a;
            }

            public override string ToString()
            {
                return dia + "-" + mes + "-" + anio;
            }

        }

        struct Amigos
        {
            public string nombre;
            public string apellido;
            public Fecha fechaNacimiento;

            public Amigos(string nom, string ape, int d, int m, int a)
            {
                nombre = nom;
                apellido = ape;
                //fechaNacimiento.dia = 1;
                //fechaNacimiento.mes = 1;
                //fechaNacimiento.anio = 0;                
                fechaNacimiento = new Fecha(d, m, a);
            }


            public void setearNombres(string nom, string ape)  //Sobrecarga 1 
            {
                nombre = nom;
                apellido = ape;
            }

            public void setearNombreCompleto(string nom, string ape, string apodo)  //Sobrecarga 2
            {
                nombre = nom;
                apellido = ape;
            }

            public void setearNombreSolo(string nom)  //Sobrecarga 3
            {
                nombre = nom;
            }

            public string getNombreYApellido()
            {
                return nombre + ", " + apellido;
            }

            public int getEdadActual()
            {
                int anioActual = 2022;
                return anioActual - fechaNacimiento.anio;
            }

            public bool esMayor()
            {
                bool result = false;
                if ((getEdadActual()) > 18)
                {
                    return true;
                }
                return result;

            }


            public void setearFechaNacimiento(int d, int m, int a)
            {
                //fechaNacimiento.dia = d;
                //fechaNacimiento.mes = m;
                //fechaNacimiento.anio = a;
                fechaNacimiento.setearFecha(d, m, a);
            }

            public string datos()
            {
                return "Nombre:" + getNombreYApellido() + ". Nació el: " + fechaNacimiento + ", y tiene "
                    + getEdadActual() + " años. " + "Bool response: " + (esMayor() ? "es Mayor" : "es Menor");

            }

            public override string ToString()
            {
                //return nombre + ", " + fechaNacimiento.dia + "/" + fechaNacimiento.mes + "/" + fechaNacimiento.anio;
                //return getNombreYApellido() + ", y nació el: " + fechaNacimiento + " y tiene" + getEdadActual() + " años.";
                return datos();


            }

        }
        static void Main(string[] args)
        {
            Amigos[] listaAmigo = new Amigos[3]; //Crear arreglo

            listaAmigo[0] = new Amigos("Pablo", "al", 31, 4, 1999); //Inicializar cada elemento
            listaAmigo[1] = new Amigos("Chicha", "dos", 10, 2, 1985);
            listaAmigo[2] = new Amigos("Xuxa", "tres", 20, 3, 2025);


            listaAmigo[1].setearFechaNacimiento(11, 11, 1111);
            listaAmigo[2].setearNombreSolo("Tita");
            listaAmigo[2].setearNombres("Tota", "apellido raro");


            Console.WriteLine("paso1");
            Console.WriteLine(listaAmigo[0]); //Mostrar elemento por elemento
            Console.WriteLine(listaAmigo[1]);
            Console.WriteLine(listaAmigo[2]);

            Console.WriteLine("Ingrese mes");
            string intro = Console.ReadLine();
            int mesAVer = int.Parse(intro);
            int contador = 0;

            for (int i = 0; i < listaAmigo.Length; i++)
            {
                Console.WriteLine(i + " > " + listaAmigo[i]);
                if (listaAmigo[i].fechaNacimiento.mes == mesAVer)
                {
                    contador++;
                }
            }
            Console.WriteLine("En el mes " + mesAVer + " cumplen = " + contador + " amigo(s)");

        }
    }
}