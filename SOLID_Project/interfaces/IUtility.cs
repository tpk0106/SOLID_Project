namespace SOLID_Project.interfaces
{
    // interface segregation (ISP)
    // instead of putting all interfaces into one, the only necessary interfaces 
    // should be deifned into a small interface module. doing so the client, in this case
    // DistinctNumbers class only install required method,ArrangeIncreasing, not other method,
    // ArrangeDecreasing defined in another interface, ISortDescend (for future requirement). 
    public interface IUtility
    {
        public Task AscendingArray();      
        public int MinNumber();
        public Task<string> PrintArray();
        public Task<int[]> CopyArray(int[] originalArray);
    }
}
