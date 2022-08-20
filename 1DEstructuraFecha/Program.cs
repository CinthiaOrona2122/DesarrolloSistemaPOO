struct Fecha
{
    public int dia;
    public int mes;
    public int anio;

    public Fecha(int d, int m, int a)
    {
        Console.WriteLine("En el constructor con 3 parametros");
        dia = d;
        mes = m;
        anio = a;
        if (dia > 31 || mes > 12 || anio > 2022)
        {
            Console.WriteLine("Error en los datos de la fecha");
            dia = 1;
            mes = 1;
            anio = 2022;
        }
    }

    public Fecha()
    {
        Console.WriteLine("El constructor sin parametros");
        dia = 1;
        mes = 1;
        anio = 1;
    }

    public int diferencia(DateTime f)
    {
        var x = new DateTime(anio, mes, dia);
        var dif = f.Subtract(x);
        return dif.Days;
    }
    public string getTexto()
    {
        return dia.ToString() + '/' + mes.ToString() + '/' + anio.ToString();
    }

    static void Main()
    {
        Fecha cumple = new Fecha(13, 11, 2021);
        Fecha otroCumple = new Fecha();

        Console.WriteLine(cumple.getTexto());
        Console.WriteLine(otroCumple.getTexto());

        /*
        var diasRestan = cumple.diferencia(DateTime.Now);
        Console.WriteLine("mi cumple es el" + cumple.getTexto() + "y viví" +diasRestan + "dias");
  */
    }
}
