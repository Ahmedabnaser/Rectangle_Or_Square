namespace Rectangle_Or_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter the width and the length of your shape");
            int width, length;
            width = int.Parse(Console.ReadLine());
            length = int.Parse(Console.ReadLine());
            if (width == length)
                Console.WriteLine("this is a square");
            else
                Console.WriteLine("this is a rectangle");
        }
    }
}
