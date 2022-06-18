// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");
int IS_PART_TIME = 1;
int IS_FULL_TIME = 2;
int EMP_RATE_PER_HOUR = 20;
int empHrs = 0;
int empWage = 0;
Random obj = new Random();
int num = obj.Next(0, 3);
if (num == IS_FULL_TIME)
{
    empHrs = 8;
}
else if (num == IS_PART_TIME)
{
    empHrs = 4;
}
else
{
    empHrs = 0;
}
empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Emp Wage : " + empWage);
        
    




