public class Twitter
{
    class Tweet
    {
        public int TweetId;
        public int Time;

        public Tweet(int tweetId, int time)
        {
            TweetId = tweetId;
            Time = time;
        }
    }

    class Node
    {
        public int UserId;
        public int Index;
        public Tweet Tweet;

        public Node(int userId, int index, Tweet tweet)
        {
            UserId = userId;
            Index = index;
            Tweet = tweet;
        }
    }

    private int time;
    private Dictionary<int, HashSet<int>> follows;
    private Dictionary<int, List<Tweet>> tweets;

    public Twitter()
    {
        time = 0;
        follows = new Dictionary<int, HashSet<int>>();
        tweets = new Dictionary<int, List<Tweet>>();
    }

    private void InitUser(int userId)
    {
        if (!follows.ContainsKey(userId))
        {
            follows[userId] = new HashSet<int>();
            follows[userId].Add(userId); // follow self
        }

        if (!tweets.ContainsKey(userId))
        {
            tweets[userId] = new List<Tweet>();
        }
    }

    public void PostTweet(int userId, int tweetId)
    {
        InitUser(userId);
        tweets[userId].Add(new Tweet(tweetId, time++));
    }

    public List<int> GetNewsFeed(int userId)
    {
        InitUser(userId);

        List<int> feed = new();

        // Max heap using negative timestamp.
        PriorityQueue<Node, int> pq = new();

        foreach (int followee in follows[userId])
        {
            if (!tweets.ContainsKey(followee) || tweets[followee].Count == 0)
                continue;

            int idx = tweets[followee].Count - 1;
            var tweet = tweets[followee][idx];

            pq.Enqueue(new Node(followee, idx, tweet), -tweet.Time);
        }

        while (pq.Count > 0 && feed.Count < 10)
        {
            Node cur = pq.Dequeue();
            feed.Add(cur.Tweet.TweetId);

            int prev = cur.Index - 1;

            if (prev >= 0)
            {
                var tweet = tweets[cur.UserId][prev];
                pq.Enqueue(new Node(cur.UserId, prev, tweet), -tweet.Time);
            }
        }

        return feed;
    }

    public void Follow(int followerId, int followeeId)
    {
        InitUser(followerId);
        InitUser(followeeId);

        follows[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (followerId == followeeId)
            return;

        if (follows.ContainsKey(followerId))
        {
            follows[followerId].Remove(followeeId);
        }
    }
}