public class MedianFinder {
    PriorityQueue<int, int> maxHeap;
    PriorityQueue<int, int> minHeap;
    public MedianFinder() {
        maxHeap = new();
        minHeap = new();
    }

    public void AddNum(int num) {
        if (maxHeap.Count == 0 || maxHeap.Peek() >= num) {
            maxHeap.Enqueue(num, -num);
        } else {
            minHeap.Enqueue(num, num);
        }

        if (maxHeap.Count > minHeap.Count + 1) {
            int top = maxHeap.Dequeue();
            minHeap.Enqueue(top, top);
        } else if (maxHeap.Count < minHeap.Count) {
            int top = minHeap.Dequeue();
            maxHeap.Enqueue(top, -top);
        }
    }

    public double FindMedian() {
        if(maxHeap.Count == minHeap.Count){
            return maxHeap.Peek() / 2.0 + minHeap.Peek() / 2.0;
        }
        
        return maxHeap.Peek();
    }
}
