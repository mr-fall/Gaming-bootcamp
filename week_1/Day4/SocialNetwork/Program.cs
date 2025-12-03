using System;

class Program
{
    static void Main()
    {
        User alice = new User("MrFall", 25);
        User bob = new User("Symbol", 30);
        User carol = new User("Yassine", 22);
        
        MrFall.AddFriend(Symbol);
        Symbol.AddFriend(Yassine);
        
        Post post1 = new Post(MrFall, "Salam 3alikum!");
        MrFall.Posts.Add(post1);
        
        Comment comment1 = new Comment(Symbol, "Post zwine!");
        post1.AddComment(comment1);
        
        post1.AddLike(Symbol);
        comment1.AddLike(Yassine);
        
        Symbol.ShowFeed();
        
        Console.WriteLine("\nSalina, Safi Salina !");
    }
}
