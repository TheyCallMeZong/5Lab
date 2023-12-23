namespace ConsoleApp2;

public class NumberConverter
{
    public static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber < 0)
        {
            return String.Empty;
        }
        return Convert.ToString(decimalNumber, 2);
    }
}