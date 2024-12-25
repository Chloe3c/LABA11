class Program
{
    static void Main()
    {
        MobileOperator operator1 = new MobileOperator("Оператор 1", 0.5, 10000);
        operator1.DisplayInfo();

        Console.WriteLine();

        MobileOperatorWithConnectionFee operator2 = new MobileOperatorWithConnectionFee("Оператор 2", 0.3, 15000, true);
        operator2.DisplayInfo();

        Console.WriteLine();

        MobileOperatorWithConnectionFee operator3 = new MobileOperatorWithConnectionFee("Оператор 3", 0.2, 20000, false);
        operator3.DisplayInfo();
    }
}