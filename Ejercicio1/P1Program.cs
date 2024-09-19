internal class Program
{
    private static void Main(string[] args)
    {
        string nombre;
        int sbruto, ventas, tiemp;
        double comision = 0, dsctoaños = 0, totalganado, sneto;
        Console.WriteLine("\n");
        Console.WriteLine("Escriba el nombre del trabajador de MiEmpresa SA:");
        nombre = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Ingrese el salario bruto de " + nombre+" :");
        sbruto = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("Ingrese el total de ventas de " + nombre+" :");
        ventas = int.Parse(Console.ReadLine());
        if (ventas <= 600)
            comision = ventas * 0.05;
        else if (ventas > 600 && ventas <= 3000)
            comision = ventas * 0.07;
        else if (ventas > 3000)
            comision = (ventas * 0.06) + 300;

        totalganado = comision + sbruto;

        Console.WriteLine("Ingrese los años de antiguedad de " + nombre+" :");
        tiemp=int.Parse(Console.ReadLine());

        if (tiemp <= 3)
            dsctoaños = totalganado * 0.065;
        else if (tiemp > 3)
            dsctoaños = totalganado * 0.045;
        
        sneto=totalganado-dsctoaños;


        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("\n");
        Console.WriteLine("Total ganado :" + totalganado);
        Console.WriteLine("Descuento por años de antiguedad :"+dsctoaños);
        Console.WriteLine("Sueldo Neto: "+sneto);
        Console.WriteLine("\n");
        Console.ReadKey();



    }
}