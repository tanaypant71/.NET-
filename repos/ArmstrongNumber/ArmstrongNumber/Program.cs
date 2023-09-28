using System;
namespace ArmstrongNumber
{
    class Program
    {

        static int GetNumberOfDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int num = 153;
            int temp = num;
            int numofdig = GetNumberOfDigits(num);
            int sum = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numofdig);
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine(num + ":The number is armstrong");
            }
            else
            {
                Console.WriteLine(" The number is not armstrong");
            }
        }
    }
}
