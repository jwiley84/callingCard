using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace callingCard.Controllers
{
    public class ccController : Controller
    {
        [HttpGet]
        [Route("{first_name}/{last_name}/{age}/{fave_color}")]
        public JsonResult doesThisMatter(string first_name, string last_name, int age, string fave_color) {
            var AnonObject = new {
                first_name = first_name,
                last_name = last_name,
                age = age,
                fave_color = fave_color
            };
            
            return Json(AnonObject);
        }
        
    }
}