using System;
using System.Collections.Generic;

public class Comment
{
    public User Author { get; }
    public string Content { get; }
    public List<User> Likes { get; }

    public Comment(User author, string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new Exception("Comment ma y9drch ykoun khawi!");

        Author = author;
        Content = content;
        Likes = new List<User>();
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine("User deja 3ml like f had comment");
            return;
        }

        Likes.Add(user);
    }
}
