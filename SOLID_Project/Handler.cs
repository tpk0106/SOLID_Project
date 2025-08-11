
using SOLID_Project.Models;

namespace SOLID_Project
{
    public static class Handler
    {
        public static void GetMissingDistinctNumber(int[] input)
        {            
            if (input == null) { 
                throw new ArgumentNullException(nameof(input));
            };
                        
            DistinctNumberUtility distinctNumberUtility = new DistinctNumberUtility(input);
            string strInputs = distinctNumberUtility.PrintArray().Result;
            Console.WriteLine($"Given inputs : {strInputs}\n");            
            
            DistinctNumbers distinctNumbers = new(input, distinctNumberUtility);
            int? missingNumber = distinctNumbers.MissingNumber(distinctNumbers.Self().Result).Result;
            
            Console.WriteLine($"Missing Number is : {missingNumber}\n\n");
        }
    }
}
