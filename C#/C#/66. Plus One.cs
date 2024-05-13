using System.Reflection.PortableExecutable;

public class PlusOneClass {

    //{9,9,9,9,9,9,9,9,9,9,9};
    //{1,2,3,4}
    //{1,2,3,9}
    //{1,2,9,9}
    public int[] PlusOne(int[] digits) {
       bool increaseNextLevel = false;
       List<int> tempArray = new List<int>(); // increase when there is a chain of 9s til the end
       for(int i = digits.Length -1; i >= 0; i--){
        if (digits[i] != 9 && !increaseNextLevel ){
            tempArray.Add(digits[i]+1);
            increaseNextLevel = true;
            continue;
        }
        if (digits[i] == 9 && !increaseNextLevel){
            tempArray.Add(0);
            increaseNextLevel = false;
            continue;
        }
        tempArray.Add(digits[i]);
       }
       if (!increaseNextLevel) { //was 999..
        tempArray.Add(1);
       }
       tempArray.Reverse();
        return tempArray.ToArray();
    }
}