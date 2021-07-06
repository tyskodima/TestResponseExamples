using System.Collections.Generic;
using Swashbuckle.AspNetCore.Filters;

namespace TestResponseExample.Controllers
{
    public class ResponseExamplesProvider : IMultipleExamplesProvider<TestController.ResponseModel>
    {
        public virtual IEnumerable<SwaggerExample<TestController.ResponseModel>> GetExamples()
        {
            yield return SwaggerExample.Create(
                "Example1",
                new TestController.ResponseModel("ex1", "ex1"));

            yield return SwaggerExample.Create(
                "Example2",
                new TestController.ResponseModel("ex2", "ex2"));
        }
    }
}
