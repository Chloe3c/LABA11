using System;

public class MobileOperatorWithConnectionFee : MobileOperator
{
    private bool hasConnectionFee;

    public MobileOperatorWithConnectionFee(string operatorName, double costPerMinute, double coverageArea, bool hasConnectionFee)
        : base(operatorName, costPerMinute, coverageArea)
    {
        this.hasConnectionFee = hasConnectionFee;
    }

    public override double CalculateQuality()
    {
        double Q = base.CalculateQuality();
        if (hasConnectionFee)
        {
            return 0.7 - Q;
        }
        else
        {
            return 1.5 * Q;
        }
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Наличие платы за соединение: {hasConnectionFee}");
        Console.WriteLine($"Качество (с учетом платы): {CalculateQuality()}");
    }
}