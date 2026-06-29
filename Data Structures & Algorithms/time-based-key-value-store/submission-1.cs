public class TimeMap {

    Dictionary<string, Dictionary<int, string>> map;
    public TimeMap() {
        map = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)){
            map[key] = new();
        }

        (map[key])[timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)){
            return "";
        }

        if(map[key].ContainsKey(timestamp)){
            return (map[key])[timestamp];
        }
        
        while(!map[key].ContainsKey(--timestamp) && timestamp >= 0){}

        return timestamp < 0 ? "" : map[key][timestamp];
    }
}
