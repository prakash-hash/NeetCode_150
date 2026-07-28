public class MyHashMap {
    int[] hashMap;
    public MyHashMap() {
        hashMap = new int[1000001];
        Array.Fill(hashMap, -1);
    }
    
    public void Put(int key, int value) {
        hashMap[key] = value;
    }
    
    public int Get(int key) {
        return hashMap[key];
    }
    
    public void Remove(int key) {
        hashMap[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */