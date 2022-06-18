// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");
Random obj = new Random();
int num = obj.Next(0, 2);
if (num == 1)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}