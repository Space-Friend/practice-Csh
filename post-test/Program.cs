using System;

class Program
{
    static void Main(string[] args)
    {
        string postText = Console.ReadLine();

        Post post = new Post();
        post.Text = postText;
        post.ShowPost();
        //lol
    }
}

class Post
{
    private string text;
    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public Post()
    {
        Console.WriteLine("New post");
    }

    public void ShowPost()
    {
        Console.WriteLine(text);
    }
}