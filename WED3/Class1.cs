using System;

public class MobileOperator
{
    private string operatorName;
    private double costPerMinute;
    private double coverageArea;

    public MobileOperator(string operatorName, double costPerMinute, double coverageArea)
    {
        this.operatorName = operatorName;
        this.costPerMinute = costPerMinute;
        this.coverageArea = coverageArea;
    }

    public virtual double CalculateQuality()
    {
        return 100 * coverageArea / costPerMinute;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Оператор: {operatorName}");
        Console.WriteLine($"Стоимость за минуту: {costPerMinute}");
        Console.WriteLine($"Площадь покрытия: {coverageArea}");
        Console.WriteLine($"Качество: {CalculateQuality()}");
    }
}