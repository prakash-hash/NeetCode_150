public class Twitter {
    List<(int userId, int tweetId)> tweets;
    Dictionary<int, HashSet<int>> followers;
    public Twitter() {
        tweets = new();
        followers = new();
    }
    
    public void PostTweet(int userId, int tweetId) {
        tweets.Add((userId, tweetId));
        if(!followers.ContainsKey(userId)){
            followers[userId] = new();
            followers[userId].Add(userId);
        }
    }
    
    public List<int> GetNewsFeed(int userId) {
        int k = 1;
        int n = tweets.Count - 1;
        List<int> feed = new();
        
        if(n < 0){
            return feed;
        }

        while(k <= 10 && n >= 0){
            if(tweets[n].userId == userId || followers[userId].Contains(tweets[n].userId)){
                feed.Add(tweets[n].tweetId);
                k++;
            }
            n--;
        }
        return feed;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!followers.ContainsKey(followerId)){
            followers[followerId] = new();
        }

        followers[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        followers[followerId].Remove(followeeId);
    }
}
