using SOLID_Project.interfaces;

namespace SOLID_Project.Models
{
    public class DistinctNumbers
    {        
        int? min = 0;
        public readonly int[] _inputArr;      
        public readonly IUtility _utility;

        /*
         * Dependency Inversion (DIP)
         * high level classes should not depend on low level classes, not vice versa.  
         * instead it should depnd on abstraction/interface. 
         * also details depends on interface/abstraction.
         * 
         * This class has the single responsibility of filtering the missing number (SRP)
         * and it delegated other formatting responsibility to other class, DistinctNumberUtility.                  
         */
        public DistinctNumbers(int[] inputArr, IUtility utility)
        {
            if(utility == null)
            {
                throw new ArgumentNullException(nameof(utility));   
            }
            _inputArr = inputArr;           
            _utility = utility;

            // please note that below functionalities should be moved out of the constructor 
            // except keeping injected params validating and assigning.            // 
            // Since this is sample/small application I decided to keep this as it is. 
            Task.FromResult(_utility.AscendingArray());           
            min = _utility.MinNumber();
        }        

        public Task<int[]> Self()
        {
            return Task.FromResult(_inputArr);
        }

        public Task<int?> MissingNumber(int[] sortedArray)
        {
            for (int e = 0; e < sortedArray.Length; e++)
            {
                if (sortedArray[e] != min)
                {
                    return Task<int>.FromResult(min);
                }
                min++;
            }
            return null!;
        }
    }
}
