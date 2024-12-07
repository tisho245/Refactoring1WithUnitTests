using System;

public class PriceChangeAlert
{
    //модификаторите за достъп бяха неправилно сложени на private
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = CalculatePercentageChange(last, c); bool isSignificantDifference = IsSignificantChange(div, granica);
            string message = GenerateMessage(c, last, div, isSignificantDifference);
            Console.WriteLine(message);
            last = c;
        }
    }

    //промяна на имената на параметрите и името на самия метод, смяна на логиката,
    //така, че да не прави всеки път проверка,
    //а да стигне до съответната проверка и директно да върне съобщението
    public static string GenerateMessage(double current, double last, double change, bool isSignificant)
    {
        
        if (change == 0)
        {
            //.Format не е необходим
            // to = string.Format("NO CHANGE: {0}", c);
            return $"NO CHANGE: {current}";
        }
        else if (!isSignificant)
        {
            //  to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
            return $"MINOR CHANGE: {last} to {current} ({change:F2}%)";
        }
        else if (change > 0)
        {
            //to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
            return $"PRICE UP: {last} to {current} ({change:F2}%)";
        }
        else  //целувкови скоби, подобряват четимостта на кода
        {
            //to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
            return $"PRICE DOWN: {last} to {current} ({change:F2}%)";
        }

        
    }
    public static bool IsSignificantChange(double change, double border)
    {
        // логическото условие не е необходимо и има грешка в логиката
        return Math.Abs(change) >= border;
      
    }
    //промяна на имена на параметри
    public static double CalculatePercentageChange(double oldPrice, double newPrice)
    {
        
      
        return ((newPrice - oldPrice) / oldPrice)*100;
    }
}
