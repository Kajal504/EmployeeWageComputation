// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");
const int IS_PART_TIME = 1;
const int IS_FULL_TIME = 2;
const int EMP_RATE_PER_HOUR = 20;
int empHrs = 0;
int empWage = 0;
Random obj = new Random();
int num = obj.Next(0, 3);
switch (num)
{
    case IS_FULL_TIME:
        empHrs = 8;
        break;
    case IS_PART_TIME:
        empHrs = 4;
        break;
    default:
        empHrs = 0;
        break;
}
empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Employee wage : " + empWage);
        
    


