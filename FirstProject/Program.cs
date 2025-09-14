namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mone: ");
            int mone = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mechane");
            int mechane = int.Parse(Console.ReadLine());
            DecimalFrac dce = new DecimalFrac(mone, mechane);
            int ans = dce.Calc();
            int sherit = dce.div();
            Console.WriteLine("ans: " + ans);
            Console.WriteLine("sherit: " + sherit);



        }
    }
}
