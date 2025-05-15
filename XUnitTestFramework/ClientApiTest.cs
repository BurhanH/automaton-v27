using System.Net;
using Refit;
using System.Text.Json;
using ClientApi;

namespace XUnitTestFramework;

public class ClientApiTest
{
    private readonly IClientApi _clientApi;
    
    public ClientApiTest()
    {
        _clientApi = RestService.For<IClientApi>(IClientApi.BaseUrl);
    }
    
    [Fact]
    public async Task GetPosts()
    {
        // Arrange
        
        // Act
        var response = await _clientApi.GetPosts();
        
        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(response.Content);
        
        var jsonString = await response.Content.ReadAsStringAsync();
        Assert.NotEmpty(jsonString);
        
        var posts = JsonSerializer.Deserialize<List<PostResponse>>(jsonString);
        Assert.NotNull(posts);
        Assert.NotEmpty(posts);
        Assert.True(posts.Count > 0);
        Assert.Equal(100, posts.Count);
    }
}