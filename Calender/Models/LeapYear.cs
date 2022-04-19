
namespace Calender.Models
{
    public class LeapYear
    {
        /* To be a leap year, the year number must be divisible 
         * by four – except for end-of-century years, which must be divisible by 400.*/
        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else
            {
                return year % .4 == 0;   
            }
        }
    }
}
