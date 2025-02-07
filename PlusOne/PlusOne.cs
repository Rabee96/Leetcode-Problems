public class Solution {
    public int[] PlusOne(int[] digits) {

        int pointer = digits.Length - 1;
        if(++digits[pointer] % 10 != 0) return digits;

        while(digits[pointer] % 10 == 0 && pointer-- > 0){
            digits[pointer + 1] = 0;
            digits[pointer]++;
        }
        if(digits[0] % 10 == 0){
            int[] result = new int[digits.Length + 1];
            result[digits.Length - 1] = 0;
            result[0] = 1;
            return result;
        }
        return digits;
    }   
}