namespace ConsoleApp2;

public class Post
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public override string ToString()
    {
        return $"{Id}\n{Title}\n{Body}\n\n";
    }
}