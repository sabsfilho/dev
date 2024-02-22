using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using NUnit.Framework;
using WebApi.Models;

namespace WebApiTests
{
    [TestFixture]
    public class TodoItemsControllerTests
    {
        private WebApiFactory _factory;
        private HttpClient _client;
      
        private static StringContent CreateTodo(string name, bool isComplete = false)
        {
            var item = JsonSerializer.Serialize(
                new { Name = name, IsComplete = isComplete }
            );
            var content = new StringContent(item);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        }
    
        [SetUp]
        public void SetUp()
        {
            _factory = new WebApiFactory();
            _client = _factory.CreateClient();
        }
    
        [Test]
        public async Task CreateTodoItemRespondsWithCreated()
        {
            var content = CreateTodo("write a letter");
            var response = await _client.PostAsync("/api/TodoItems", content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            string responseBody = await response.Content.ReadAsStringAsync();
         
            try
            {
                var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true}; 
                var actual = JsonSerializer.Deserialize<TodoItem>(responseBody, options);
                Assert.That(actual.Id, Is.EqualTo(1));
                Assert.That(actual.Name, Is.EqualTo("write a letter"));
                Assert.That(actual.IsComplete, Is.EqualTo(false));
            }
            catch (System.Text.Json.JsonException)
            {
                Assert.Fail("Could not deserialize response JSON:" + Truncate(responseBody));
            }
        }
    
        [Test]
        public async Task GetTodoItemsRespondsWithOk()
        {
            var content = CreateTodo("get a haircut");
            var response = await _client.PostAsync("/api/TodoItems", content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            response = await _client.GetAsync("/api/TodoItems");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            string responseBody = await response.Content.ReadAsStringAsync();
         
            try
            {
                var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
                var actual = JsonSerializer.Deserialize<List<TodoItem>>(responseBody, options);
                Assert.That(actual.Count, Is.EqualTo(1));
                Assert.That(actual[0].Id, Is.EqualTo(1));
                Assert.That(actual[0].Name, Is.EqualTo("get a haircut"));
                Assert.That(actual[0].IsComplete, Is.EqualTo(false));
            }
            catch (System.Text.Json.JsonException)
            {
                Assert.Fail("Could not deserialize response JSON:" + Truncate(responseBody));
            }
        }
    
        [Test]
        public async Task DeleteTodoItemsRespondsWithNoContent()
        {
            var content = CreateTodo("read a book");
            var response = await _client.PostAsync("/api/TodoItems", content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            response = await _client.DeleteAsync("/api/TodoItems/1");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent));
            response = await _client.GetAsync("/api/TodoItems");
            string responseBody = await response.Content.ReadAsStringAsync();
         
            try
            {
                var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
                var actual = JsonSerializer.Deserialize<List<TodoItem>>(responseBody, options);
                Assert.That(actual.Count, Is.EqualTo(0));
            }
            catch (System.Text.Json.JsonException)
            {
                Assert.Fail("Could not deserialize response JSON:" + Truncate(responseBody));
            }
        }
    
        [Test]
        public async Task PutTodoItemsRespondsWithNoContent()
        {
            var content = CreateTodo("fly a kite");
            var response = await _client.PostAsync("/api/TodoItems", content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            content = new StringContent(JsonSerializer.Serialize(
                new { Id = 1, Name = "fly a kite", IsComplete = true }
            ));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            response = await _client.PutAsync("/api/TodoItems/1", content);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent));
            response = await _client.GetAsync("/api/TodoItems/1");
            string responseBody = await response.Content.ReadAsStringAsync();
         
            try
            {
                var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
                var actual = JsonSerializer.Deserialize<TodoItem>(responseBody, options);
                Assert.That(actual.Id, Is.EqualTo(1));
                Assert.That(actual.Name, Is.EqualTo("fly a kite"));
                Assert.That(actual.IsComplete, Is.EqualTo(true));
            }
            catch (System.Text.Json.JsonException)
            {
                Assert.Fail("Could not deserialize response JSON:" + Truncate(responseBody));
            }
        }
    
        [TearDown]
        public void TearDown()
        {
            _client.Dispose();
            _factory.Dispose();
        }
      
        private static string Truncate(string s, int threshold = 200, int trunc = 50)
        {
            if (s.Length > threshold) 
            {
                return s.Substring(0, trunc) +  "..." + s.Substring(s.Length - trunc);
            } 
          
            return s;
        }
    }
}
