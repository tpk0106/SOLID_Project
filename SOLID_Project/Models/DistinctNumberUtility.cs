using SOLID_Project.interfaces;

namespace SOLID_Project.Models
{
    public class DistinctNumberUtility:IUtility
    {
        public readonly int[] _numbers;
        public readonly int[] _origArray;

        // Single Responsibility (SRP)        
        // DistinctNumberUtility class has only handles the formatting, copying, ordering 
        // of the input array. 

        public DistinctNumberUtility(int[] numbers)
        {
            _numbers = numbers;
            _origArray =  CopyArray(numbers).Result;
        }

        public Task AscendingArray()
        {
            for (int x = 0; x < _numbers.Length; x++)
            {
                for (int y = 0; y < _numbers.Length - 1; y++)
                {
                    int num = 0;
                    if (_numbers[y] >= _numbers[y + 1])
                    {
                        num = _numbers[y + 1];
                        _numbers[y + 1] = _numbers[y];
                        _numbers[y] = num;
                    }
                }
            }
            return Task.CompletedTask;
        }

        public Task<int[]> CopyArray(int[] originalArray)
        {
            int[] arr = new int[originalArray.Length];
            for(int i=0;i<originalArray.Length;i++)
            {
                arr[i] = originalArray[i];
            }
            return Task.FromResult(arr);
        }       

        public int MinNumber()
        {
            return _numbers[0];
        }

        public Task<string> PrintArray()
        {
            string display = string.Empty;
            foreach(var e in _origArray)
            {
                display += e.ToString() + ", ";
            }
            return Task.FromResult(display);
        }
    }
}
