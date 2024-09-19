internal class Program
{
    private static void Main(string[] args)
    {
        string i="";
        int autos,numplaca,verde=0,azul=0,rojo=0;

        Console.WriteLine("Ingrese el número de autos: ");
        autos=int.Parse(Console.ReadLine());



        do
        {
            Console.WriteLine("Ingrese último número de la placa del auto :");
            numplaca = int.Parse(Console.ReadLine());
            
           
            if (numplaca >= 0 && numplaca < 4)
                verde++;
            else if (numplaca >= 4 && numplaca < 7)
                azul++;
            else if (numplaca >= 7 && numplaca <= 9)
                rojo++;
            Console.WriteLine("Para termina presione (F), sino presione (S):");
                i = Console.ReadLine();

        } while (i != "F");




        Console.WriteLine("\n");
        Console.WriteLine("Número de autos: " + autos);
        Console.WriteLine("\n");
        Console.WriteLine("Autos con placa color verde: "+verde);
        Console.WriteLine("Autos con placa color azul: " + azul);
        Console.WriteLine("Autos con placa color rojo: " + rojo);
        Console.WriteLine("\n");
        Console.ReadKey();








    }
}