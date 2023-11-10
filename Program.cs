internal class Program
{
    private static void Main(string[] args)
    {
        int NumeroUsuario1 = 0;
        int NumeroUsuario2 = 0;
        int total = 0;
        Console.WriteLine("Dame el primer numero: ");
        NumeroUsuario1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dame el segundo numero: ");
        NumeroUsuario2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(total = NumeroUsuario1 + NumeroUsuario2);
        Console.WriteLine("si quieres cerrarlo pulsa una tecla");
        Console.ReadKey();
    }
}