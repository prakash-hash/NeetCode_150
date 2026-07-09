public class Twitter {
    List<(int userId, int tweetId)> tweets;
    Dictionary<int, HashSet<int>> followers;
    public Twitter() {
        tweets = new();
        followers = new();
    }

    public void PostTweet(int userId, int tweetId) {
        tweets.Add((userId, tweetId));
        if (!followers.ContainsKey(userId)) {
            followers[userId] = new();
            followers[userId].Add(userId);
        }
    }

    public List<int> GetNewsFeed(int userId) {
        if (!followers.ContainsKey(userId))
            return new List<int>();

        int i = tweets.Count - 1;
        List<int> feed = new();

        while (i >= 0 && feed.Count < 10) {
            if (followers[userId].Contains(tweets[i].userId))
                feed.Add(tweets[i].tweetId);
            i--;
        }

        return feed;
    }

    public void Follow(int followerId, int followeeId) {
        if (!followers.ContainsKey(followerId))
            followers[followerId] = new HashSet<int>();

        followers[followerId].Add(followerId);  // always follow self
        followers[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId) {
        if (followerId == followeeId)
            return;

        if (followers.ContainsKey(followerId))
            followers[followerId].Remove(followeeId);
    }
}
