namespace _1D25Junio
{
    internal class D25Agosto
    {
        struct Fecha
        {
            public int dia;
            public int mes;
            public int anio;

            public Fecha(int d, int m, int a)
            {
                this.dia = d;
                this.mes = m;
                this.anio = a;
            }

            public override string ToString()
            {
                return dia + "-" + mes + "-" + anio;
            }

        }
        struct Persona
        {
            public string nombre;
            public string apellido;
            public string telefono;
            public Fecha nacimiento;

            public Persona(string nom, string ape, string telef, int d, int m, int a)
            {
                nombre = nom;
                apellido = ape;
                telefono = telef;
                nacimiento = new Fecha(d,m,a);
            }

            public override string ToString()
            {
                return nombre + " " + apellido + ", " + nacimiento.ToString();
            }

        }
        
        static void Main(string[] args)
        {
            //Persona per = new Persona("Pablo", "Avellaneda", "no tiene", 10,3,1999);
            //Persona per2 = new Persona("Matias", "Soria", "no tiene", 5,7,1985);

            //Console.WriteLine(per);
            //Console.WriteLine(per2);

            Persona[] amigos = new Persona[3];
            amigos[0] = new Persona("Pablo", "Avellaneda", "no tiene", 10, 3, 1999);
            amigos[1] = new Persona("Victor", "Gomez", "no tiene", 11, 6, 2022);
            amigos[2] = new Persona("Juan", "Perez", "no tiene", 1, 3, 1985);

            //Console.WriteLine(amigos[0]);
            //Console.WriteLine(amigos[1]);
            //Console.WriteLine(amigos[2]);


            Console.WriteLine("Lista de cumpleaños del mes de Marzo");
            foreach(var miAmigo in amigos)
            {
                if(miAmigo.nacimiento.mes == 3)
                {
                    Console.WriteLine(miAmigo);
                }
            }

        }
    }
}