using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
  internal class Utilities
  {
    public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
    {
      if (numberOfMonthsWorked == 12)
        return monthlyWage * (numberOfMonthsWorked + 1);

      return monthlyWage * numberOfMonthsWorked;
    }

    // example of method overloading
    public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
    {
      if (numberOfMonthsWorked == 12)
        return monthlyWage * (numberOfMonthsWorked + 1);

      return monthlyWage * numberOfMonthsWorked + bonus;
    }

    // example of optional parameters
    public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus=0)
    {
      if (numberOfMonthsWorked == 12)
        return monthlyWage * (numberOfMonthsWorked + 1);

      return monthlyWage * numberOfMonthsWorked + bonus;
    }

    // example of expression-bodied syntax
    public static int AddNumbers(int a, int b) => a + b;
    
  }
}