using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public string Name { get; }
    public int Age { get; }

    public List<User> Friends { get; }
    public List<Post> Posts { get; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
        Friends = new List<User>();
        Posts = new List<Post>();
    }

    public void AddFriend(User user)
    {
        if (user == this)
        {
            Console.WriteLine("Ma t9drch tzid rask f friends.");
            return;
        }

        if (Friends.Contains(user))
        {
            Console.WriteLine("Had user deja friend dyalek.");
            return;
        }

        Friends.Add(user);
        Console.WriteLine($" {Name} zid {user.Name} f friends.");
    }

    public void RemoveFriend(User user)
    {
        if (!Friends.Contains(user))
        {
            Console.WriteLine("Had user ma howash friend dyalek.");
            return;
        }

        Friends.Remove(user);
        Console.WriteLine($"🗑️ {Name} hdd {user.Name} mn friends.");
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n===== Feed dyal {Name} =====\n");

        var allPosts = new List<Post>();

        foreach (var friend in Friends)
        {
            allPosts.AddRange(friend.Posts);
        }

        if (allPosts.Count == 0)
        {
            Console.WriteLine("Mafhmtch chi posts hna");
            return;
        }

        foreach (var post in allPosts.OrderByDescending(p => p.Timestamp))
        {
            Console.WriteLine($"{post.Author.Name} 3ml post: \"{post.Content}\" (Likes: {post.Likes.Count})");

            foreach (var comment in post.Comments)
            {
                Console.WriteLine($"  - {comment.Author.Name} 3ml comment: \"{comment.Content}\" (Likes: {comment.Likes.Count})");
            }

            Console.WriteLine();
        }
    }
}
