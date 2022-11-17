using BethanysPieShopHRM;

int amount = 1234;
int months = 12;
int bonus = 500;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);
int yearlyWageWithBonus = Utilities.CalculateYearlyWage(amount, months, bonus);

Console.WriteLine($"Yearly wage: {yearlyWage}");

int number = Utilities.AddNumbers(1, 2);
Console.WriteLine(number);
