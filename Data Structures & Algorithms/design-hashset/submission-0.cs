public class MyHashSet {
    bool[] hashSet;
    
    public MyHashSet() {
        hashSet = new bool[1000000];
    }
    
    public void Add(int key) {
        hashSet[key] = true;
    }
    
    public void Remove(int key) {
        hashSet[key] = false;
    }
    
    public bool Contains(int key) {
        return hashSet[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */