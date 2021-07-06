using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Filters;

namespace TestResponseExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public class ResponseModel
        {
            public ResponseModel(string property1, string property2)
            {
                Property1 = property1;
                Property2 = property2;
            }
            public string Property1 { get; set; }

            public string Property2 { get; set; }
        }

        [HttpPost("action1")]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status400BadRequest)]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(ResponseExamplesProvider))]
        public ActionResult<ResponseModel> Action1()
        {
            return BadRequest(new ResponseModel("action1", "action1"));
        }

        [HttpPost("action2")]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status500InternalServerError)]
        public ActionResult<ResponseModel> Action2()
        {
            return BadRequest(new ResponseModel("action2", "action2"));
        }
    }
}
