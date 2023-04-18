using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("222222")]
        public int GetAll()
        {
            return 111;
        }

        [HttpGet("333333")]
        public int Get333333()
        {
            return 8888;
        }




        [HttpPost("333333")]
        public ResponceModel Get333333(TestModel testModel) //accepted parameters model
        {
            // ResponceModel return parameters model
            ResponceModel responceModel = new ResponceModel();
            responceModel.Id= testModel.Name1+100;
            responceModel.Name = testModel.Name2+"testing";
            responceModel.Description = testModel.Name2 + "testing description";

            return responceModel;
        }




        [HttpDelete("myDelete")]
        public RequestModel Get333(TestModel testModel) //accepted parameters model
        {
            // ResponceModel return parameters model
            RequestModel requestModel = new RequestModel();
            requestModel.Id1 = testModel.Name1 + 100;
            requestModel.Name1 = testModel.Name2 + "testing";
            requestModel.Description1 = testModel.Name2 + "testing description";

            return requestModel;
        }


    }
}
