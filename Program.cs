using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.check_which_number_is_closest_to_100
{
   using System;

public class Program
{
    public static int Check(int num1, int num2)
    {
        if (num1 == num2)
        {
            return 0;
        }

        int difference1 = Math.Abs(num1 - 100);
        int difference2 = Math.Abs(num2 - 100);

        if (difference1 < difference2)
        {
            return num1;
        }
        else if (difference2 < difference1)
        {
            return num2;
        }
        else
        {
            return 0;
        }
    }

    public static void Main(string[] args)
    {
        int[] inputNumbers1 = { 78, 95, 99};
        int[] inputNumbers2 = { 95, 95, 70 };

        for (int i = 0; i < inputNumbers1.Length; i++)
        {
            int result = Check(inputNumbers1[i], inputNumbers2[i]);
            Console.WriteLine($"{inputNumbers1[i]} , {inputNumbers2[i]} -> {result}");
        }
    }
}

}
