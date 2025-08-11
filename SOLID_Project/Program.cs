namespace SOLID_Project
{
    public class Program
    {
        /*
         *  This is developed using my own manual coding without using any AI tool.
         *  some of SOILD principles is applied 
         *  Interface segregation
         *  Dependency Inversion 
         *  Single responsibility 
         */
        public static void Main(string[] args)
        {            
            Handler.GetMissingDistinctNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]);
            Handler.GetMissingDistinctNumber([3, 0, 1]);
            Handler.GetMissingDistinctNumber([9, 8, 6, 5, 4, 3, 2, 1, 0]);
            Handler.GetMissingDistinctNumber([3, 2, 0, 8, 4, 1, 5, 9, 7, 12, 10, 11]);
            Handler.GetMissingDistinctNumber([0, 2]);
            Console.ReadKey();
        }
    }
}
