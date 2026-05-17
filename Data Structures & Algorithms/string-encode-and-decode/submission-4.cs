public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder("");
        foreach(string str in strs){
            result.Append($"{str.Length}#{str}");            
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int k = 0;
        bool delimiter = false;
        string size = "";
        int sizeInt = -1;
        StringBuilder sb = new StringBuilder("");
        while(k < s.Length){
            if(s[k] == '#' && !delimiter){
                sizeInt = int.Parse(size);
                if(sizeInt == 0){
                    result.Add("");

                    size="";
                    sizeInt = -1;
                    k++;
                    
                    delimiter = false;
                    continue;
                }
                delimiter = true;
                k++;
                continue;
            }

            if(!delimiter){
                size += s[k];
            }

            if(delimiter){
                sb.Append(s[k]);
                sizeInt--;
            }

            if(sizeInt == 0){
                result.Add(sb.ToString());
                sb.Clear();
                size = "";
                sizeInt = -1;
                delimiter = false;
            }

            k++;
        }    
        return result;
    }
}

/*
Common Pitfalls
Using a Delimiter That Can Appear in the Strings
Choosing a simple delimiter like a comma or space will break decoding if that character appears inside the original strings. The length-prefixing approach avoids this by using the length to know exactly how many characters to read, making the content irrelevant.

Not Handling Empty Strings or Empty Lists
Edge cases like an empty input list or strings that are themselves empty ("") require careful handling. Ensure your encoding distinguishes between an empty list and a list containing one empty string, and that decoding correctly reconstructs zero-length strings.

Parsing Length Incorrectly for Multi-Digit Numbers
When the length of a string is 10 or more, the length prefix becomes multi-digit. Ensure you read all digits before the # separator rather than just assuming a single digit. Using a loop to collect characters until reaching # handles this correctly.
*/
