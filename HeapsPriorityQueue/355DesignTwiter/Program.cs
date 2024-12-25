using System.Collections.Generic;
using System.IO;

namespace _355DesignTwiter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Twitter
    {
        //<userId -> User>
        Dictionary<int, User> userIdToUser = new();
        int time;

        public class User
        {
            public int userId;

            //<tweetId, time>
            public PriorityQueue<int, int> PostHeap = new();

            //followerId
            public SortedList<int> followerList = new();
            public SortedList<int> followingList = new();

            //tweetId, time
            public PriorityQueue<int, int> FeedHeap = new();

            public User(int userId)
            {
                this.userId = userId;
            }
        }

        public Twitter()
        {
            time = 0;
        }

        public void PostTweet(int userId, int tweetId)
        {
            time++;
            User user;
            if (!userIdToUser.TryGetValue(userId, out user))
            {
                user = new(userId);
                userIdToUser[userId] = user;
            }
            user.PostHeap.Enqueue(tweetId, -time);
            user.FeedHeap.Enqueue(tweetId, -time);
            foreach (int follower in this.followerList)
            {
                userIdToUser[follower].FeedHeap.Enqueue(tweetId, -time);
            }
        }

        public IList<int> GetNewsFeed(int userId)
        {
            time++;
            User user;
            List<int> resultFeed = new();

            if (!userIdToUser.TryGetValue(userId, out user))
            {
                user = new(userId);
            }
            int tweetId;
            Queue<int> fila = new();
            for (int i = 0; i < 10; i++)
            {
                tweetId = user.FeedHeap.Dequeue();
                resultFeed.Add(tweetId);
                fila.Enqueue(tweetId);
            }
            for (int i = 0; i < 10; i++)
            {
                user.FeedHeap.Enqueue(fila.Dequeue());
            }

            return resultFeed;
        }

        public void Follow(int followerId, int followeeId) { 

        }

        public void Unfollow(int followerId, int followeeId) { 
            //HOW DO YOU REMOVE TWEETS ONCE UNFOLLOW
        }
        //Quizas un heap global y se extraen hasta que se 
        //encuentren 10 que si pertenecen al usuario
    }
}
