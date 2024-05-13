public class LengthOfLastWordClass {
    public int LengthOfLastWord(string s) {
        string trimmed = s.Trim();
        string [] division = trimmed.Split(" ");
        int lastWordIndex = division.Length;
        string lastWord = division[lastWordIndex-1];
        return lastWord.Length;
    }
}