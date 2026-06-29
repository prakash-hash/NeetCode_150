public class TimeMap {

    Dictionary<string, List<(int time, string value)>> map;
    public TimeMap() {
        map = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)){
            map[key] = new();
        }

        map[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)){
            return "";
        }

        var list = map[key];

        int l = 0;
        int r = list.Count - 1;
        string ans = "";
        while(l <= r){
            int mid = l + (r - l)/2;
            if(list[mid].time <= timestamp){
                ans =  list[mid].value;
                l = mid + 1;
            }
            else{
                r = mid - 1;
            }
        }

        return ans;
    }
}

/*
Common Pitfalls
Using Exact Match Instead of Floor Search
A common mistake is searching for an exact timestamp match instead of finding the largest timestamp less than or equal to the query. Binary search should find the rightmost value satisfying timestamp <= query, not an exact match. If no exact match exists but earlier timestamps do, returning an empty string is incorrect.

Off-By-One Errors in Binary Search
Binary search boundaries are tricky. Using bisect_left instead of bisect_right, or not adjusting the index after the search, leads to returning values from timestamps greater than the query. Always verify your binary search returns the correct floor value by testing edge cases like querying before any set operation.

Returning Empty String When Key Exists But Timestamp Is Too Early
When a key exists but all stored timestamps are greater than the query timestamp, the correct behavior is to return an empty string. Some implementations incorrectly return the earliest stored value instead. Always check that your found index is valid (non-negative) before accessing the value.
*/
