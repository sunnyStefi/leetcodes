public class Program {
    public static void Main(string[] args) 
    {
        // //35
        // int [] inputArray = {1,2,4,5};
        // SearchInsertClass searchInsertClass = new SearchInsertClass();
        // int res = searchInsertClass.SearchInsert(inputArray, 7);
        // Console.WriteLine("35:" + res);
        
        // //58
        // string input = "asd 123456 ";
        // LengthOfLastWordClass lengthOfLastWordClass = new LengthOfLastWordClass();
        // res = lengthOfLastWordClass.LengthOfLastWord(input);
        // Console.WriteLine("58:" + res);

         //66
        //  int [] plusOneClassInput = new int[]{1,2,3,4}; 
        // int [] plusOneClassInput = new int[]{1,2,3,9}; 
        //  int [] plusOneClassInput = new int[]{1,2,9,9}; 
        //  int [] plusOneClassInput = new int[]{9,9,9,9}; 
           int [] plusOneClassInput = new int[]{9,8,7}; 
        //  int [] plusOneClassInput = new int[]{9,9,9,9,9,9,9,9,9,9,9};
        PlusOneClass plusOneClass = new PlusOneClass();
        int [] resArray = plusOneClass.PlusOne(plusOneClassInput);
        Console.WriteLine("66:" + string.Join(",", resArray));
    }
}