using Home.API.Validations;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Utilities.Helpers;

namespace Home.API.Controllers.v1;
[Route("ap/[controller]")]
[ApiController]
public class ManageUsersController : ControllerBase
{
    [HttpPost("Login")]
    public ActionResult<LoginValidationModel> Login(LoginValidationModel loginValidation, CancellationToken cancellationToken)
    {
        var result = loginValidation;
        var res = ResultHelper.CreateSuccess(result, (int)HttpStatusCode.OK);
        return Ok(res);
    }
}
