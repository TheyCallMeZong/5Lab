using System.Diagnostics;
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
        foreach (var post in result)
        {
            if (post.Result != null)
            {
                Debug.WriteLine($"пост: {post.Result.Id}");
                Debug.WriteLine($"Заголовок поста: {post.Result.Title}");
                Debug.WriteLine($"Текст поста: {post.Result.Body}");

                await File.AppendAllTextAsync(path, post.Result?.ToString());
            }
        }
    }

    public async Task<Post?> GetPost(int number)
    {
        var result = await client.GetAsync($"https://jsonplaceholder.typicode.com/posts/{number}");
        Debug.WriteLine($"Статус ответа: {result.StatusCode}");
        var jsonString = JsonConvert.DeserializeObject<Post>(await result.Content.ReadAsStringAsync());
        Debug.WriteLine($"JSON-данные: {jsonString}");
        return jsonString;
    }
}