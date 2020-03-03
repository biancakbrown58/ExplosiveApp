using Microsoft.AspNetCore.Mvc;

namespace ExplosiveApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("explosion")]
    public string Explode(string s)
    {
      var answerstring = "";
      foreach (var letter in s)
      {
        var number = int.Parse(letter.ToString());
        for (var i = 0; i < number; i++)
        {
          answerstring += letter;
        }
      }
      return answerstring;
    }
  }

}
