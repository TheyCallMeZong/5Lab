using Newtonsoft.Json;

namespace ConsoleApp2;

public class GetPosts
{
    private string path = @"/Users/semensavcenko/Documents/5 семестр/ConsoleApp2/ConsoleApp2/test.txt";
    private static HttpClient client;

    public GetPosts()
    {
        client = new HttpClient();
    }

    public async Task GetPostsAsync()
    {
        var result = new List<Task<Post?>>();
        for (int i = 3; i <= 13; i++)
            result.Add(GetPost(i));
        await Task.WhenAll(result);
        foreach (var e in result)
            await File.AppendAllTextAsync(path, e.Result?.ToString());
    }

    public async Task<Post?> GetPost(int number)
    {
        var result = await client.GetAsync($"https://jsonplaceholder.typicode.com/posts/{number}");

        return JsonConvert.DeserializeObject<Post>(await result.Content.ReadAsStringAsync());
    }
}