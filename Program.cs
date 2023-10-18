internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        do
        {
            Console.WriteLine("Enter first number ");
        } while(!int.TryParse(Console.ReadLine(), out num1));
        do
        {
            Console.WriteLine("Enter second number ");
        } while(!int.TryParse(Console.ReadLine(), out num2));

        Console.WriteLine("Enter Operation (+, -, *, /)");
        char op = char.Parse(Console.ReadLine());
        double result;
        Console.WriteLine(calc(num1, num2, op, out result));
    }
    public static double calc(int num1, int num2, char op, out double result)
    {
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("unknown operation !!!!!!!");
                result = 0;
                break;
        }
        return result;
    }
}