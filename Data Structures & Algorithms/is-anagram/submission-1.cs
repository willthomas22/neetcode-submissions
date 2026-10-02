public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) { return false; }
    
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
    
        for (int i = 0; i < s.Length; i++) {
            if (sDict.TryGetValue(s[i], out int count)) {
                sDict[s[i]] = count + 1;
            } 
            else {
                sDict[s[i]] = 1;
            }
        
            if (tDict.TryGetValue(t[i], out int count2)) {
                tDict[t[i]] = count2 + 1;
            } 
            else {
                tDict[t[i]] = 1;
            }
        }

        if (sDict.Count != tDict.Count) { return false; }

        foreach (var skvp in sDict)
        {
            if (!tDict.TryGetValue(skvp.Key, out var tvalue) || skvp.Value != tvalue)
            {
                return false;
            }
        }

        return true;
    }
}
