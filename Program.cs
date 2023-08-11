namespace Logical_Programming
{
    internal class CouponNumber
    {

        public class CouponNumberExample
        {

            private static int GenerateRandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            // Function to generate distinct coupon numbers
            public static int GenerateDistinctCouponNumbers(int n)
            {
                HashSet<int> distinctCoupons = new HashSet<int>();
                int totalRandomNumbers = 0;

                while (distinctCoupons.Count < n)
                {
                    int randomNumber = GenerateRandomNumber(1, n + 1); // Assuming coupon numbers start from 1
                    totalRandomNumbers++;

                    if (!distinctCoupons.Contains(randomNumber))
                    {
                        distinctCoupons.Add(randomNumber);
                    }
                }

                return totalRandomNumbers;
            }

            public static void Main(string[] args)
            {
                Console.Write("Enter the number of distinct coupon numbers: ");
                int n = int.Parse(Console.ReadLine());

                int totalRandomNumbers = GenerateDistinctCouponNumbers(n);
                Console.WriteLine($"Total random numbers needed to have all distinct coupon numbers: {totalRandomNumbers}");
            }
        }






    }
    }  
 
