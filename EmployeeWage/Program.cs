// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");
const int IS_PART_TIME = 1;
const int IS_FULL_TIME = 2;
const int EMP_RATE_PER_HOUR = 20;
const int NUM_OF_WORKING_DAYS = 20;
const int MAX_HRS_IN_MONTH = 100;

int empHrs = 0;
int totalEmpHrs = 0;
int totalWorkingDays = 0;
while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
{
    totalWorkingDays++;
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
    totalEmpHrs += empHrs;
    Console.WriteLine("Day#: " + totalWorkingDays + "Emp Hrs: " + empHrs);
}
int totalEmpwage = totalEmpHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Total Emp Wage: " + totalEmpwage);
Console.ReadKey();
        