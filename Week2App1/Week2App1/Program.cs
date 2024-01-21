namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float firstnumber;
            float seconnumber;

            Console.WriteLine("Please enter first number");              
            firstnumber= float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second Number");
            seconnumber = float.Parse(Console.ReadLine());

            float resultSum = firstnumber + seconnumber;
            Console.WriteLine("Addition result" + resultSum);

            float resultMinus = firstnumber - seconnumber;
            Console.WriteLine("Minus result" + resultMinus);

            float resultMultipl = firstnumber * seconnumber;
            Console.WriteLine("Multipl result" + resultMultipl);

            float resultDivide = firstnumber / seconnumber;
            Console.WriteLine("Divide result" + resultDivide);
            
            Console.WriteLine("Hello, World!");
        }
    }
}