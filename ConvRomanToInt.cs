using System;

public class ConvRomanToInt {
    
    public Dictionary<char, int> sym = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
    public int RomanToInt(String r) {
        int value = 0;
        char[] chars = r.ToCharArray();
        
        for (int i = chars.Length-1; i>=0; i--)
        {
            if ((i-1 >= 0) && (sym[chars[i-1]] < sym[chars[i]]))
            {
                value += (sym[chars[i]]-sym[chars[i-1]]);
                i--;
            }
            else
            {
                value += sym[chars[i]];
            }
        }
        return value;
    }
}
