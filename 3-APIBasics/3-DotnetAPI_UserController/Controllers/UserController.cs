
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController() // without the word public you wont be able to see the response because of an error
    {

    }

    [HttpGet("GetUsers/{testValue}")] // this will show in our api with the {testValue}. so lets say testValue = iosaac the url will bet /test/iosaac
    // public IActionResult Test() // api response
    public string[] GetUsers(string testValue) //returning a sting array
    {
        string[] responseArray = new string[] {
            "test1",
            "test2",
            testValue
        };
        return responseArray;
    }
}
