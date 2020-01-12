using System;

public class DateModifier
{
    public static void differ(string str1, string str2)
    {     
        var d1 = str1.Split();
        var d2 = str2.Split();

        var value1 = new DateTime(int.Parse(d1[0]), int.Parse(d1[1]), int.Parse(d1[2]));
        var value2 = new DateTime(int.Parse(d2[0]), int.Parse(d2[1]), int.Parse(d2[2]));

        Console.WriteLine(Math.Abs((value1 - value2).TotalDays));
    }
}

