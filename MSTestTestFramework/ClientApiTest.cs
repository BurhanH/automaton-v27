using System.Net;
using Refit;
using System.Text.Json;
using ClientApi;

namespace MSTestTestFramework;

[TestClass]
public class ClientApiTest
{
    private IClientApi _clientApi;
    
    [TestInitialize]
    public void Initialize()
    {
        _clientApi = RestService.For<IClientApi>(IClientApi.BaseUrl);
    }
    
    [TestMethod]
    public void GetPosts()
    {
        // Arrange
        
        // Act
        var response = _clientApi.GetPosts();
        
        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.Result.StatusCode);
        
        var jsonString = response.Result.Content.ReadAsStringAsync().Result;
        Assert.IsNotEmpty(jsonString);
        
        var posts = JsonSerializer.Deserialize<List<PostResponse>>(jsonString);
        Assert.IsNotNull(posts);
        Assert.IsTrue(posts.Count > 0);
        Assert.AreEqual(100, posts.Count);
    }
    
    [TestMethod]
    [DataRow(1)]
    [DataRow(100)]
    [DataRow(50)]
    public void GetPost(int postId)
    {
        // Arrange
        
        // Act
        var response = _clientApi.GetPost(postId);
        
        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.Result.StatusCode);
        
        var jsonString = response.Result.Content.ReadAsStringAsync().Result;
        Assert.IsNotEmpty(jsonString);
        
        var post = JsonSerializer.Deserialize<PostResponse>(jsonString);
        Assert.IsNotNull(post);
        Assert.AreEqual(postId, post.id);
    }

    [TestMethod]
    [DataRow(10)]
    public void GetPostComments(int postId)
    {
        // Arrange

        // Act
        var response = _clientApi.GetPostComments(postId);

        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.Result.StatusCode);
        var jsonString = response.Result.Content.ReadAsStringAsync().Result;
        Assert.IsNotEmpty(jsonString);

        var comments = JsonSerializer.Deserialize<List<PostCommentResponse>>(jsonString);
        Assert.IsNotNull(comments);
        Assert.IsTrue(comments.Count > 0);
        Assert.AreEqual(5, comments.Count);
        Assert.AreEqual(comments.Select(c => c.postId == postId).Count(), 5);;
    }
}