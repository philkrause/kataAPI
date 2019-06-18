using Microsoft.AspNetCore.Mvc;
using System.Linq;
using kataapi.ViewModels;

namespace kataapi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {

    [HttpGet("add/{cocoAmt}/{sugarAmt}")]

    public ActionResult<ExplosionResult> Exp(int cocoAmt, int sugarAmt)
    {
      return new ExplosionResult
      {
        coco = cocoAmt,
        sugar = sugarAmt,
        cookingMethod = "oven"
        // result = string.Join("", s.Select(c => new string(c, int.Parse(c.ToString()))))
      };


    }
  }
}