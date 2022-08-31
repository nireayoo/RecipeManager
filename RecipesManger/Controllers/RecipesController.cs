using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesManger.Models;

namespace RecipesManger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRecipes()
        {
            public static List<RecipeModel>() recipe =  new RecipeModel
            {

            }

            return Ok(recipe);

        }


        //[HttpGet("id")]
        //public ActionResult GetRecipesById()
        //{

        //}

        [HttpPost]
        public ActionResult CreateRecipes([FromBody] RecipeModel model)
        {

        }
        //[HttpPut]
        //public ActionResult CreateRecipes()
        //{

        //}
        [HttpDelete("id")]
        public async Task<IActionResult> RemoveRecipes(string id)
        {
            return NoContent();

        }
    }
}
