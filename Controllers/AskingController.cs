// Jasmine Leek
// 25oct2022
// Asking Questions - Endpoint
// This is an api that allows says hello to the user by name and describes their mood.
// peer review Carlos Felipe - This program runs well and is creative. It asked what my mood was instead of what time I woke up. The code itsels is formatted correctly and everything looks good 

using Microsoft.AspNetCore.Mvc;

namespace LeekJAskingQsEP.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingController : ControllerBase
{
   [HttpGet]
   [Route("Questions/{name}/{mood}")]

   public string SayHello(string name, string mood)
   {
      return $"Hi {name}! How are you feeling today? I love when you are in a {mood} mood";
   }

}