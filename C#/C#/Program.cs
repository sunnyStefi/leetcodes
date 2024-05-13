public class Program {
    public static void Main(string[] args) 
    {
        int [] inputArray = {1,2,4,5};
        SearchInsertClass searchInsertClass = new SearchInsertClass();
        int res = searchInsertClass.SearchInsert(inputArray, 7);
        Console.WriteLine(res);
        
        string input = "asd 123456 ";
        LengthOfLastWordClass lengthOfLastWordClass = new LengthOfLastWordClass();
        res = lengthOfLastWordClass.LengthOfLastWord(input);
        Console.WriteLine(res);
    }
}