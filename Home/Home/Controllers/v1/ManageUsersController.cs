using Home.API.Validations;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Utilities.Helpers;

namespace Home.API.Controllers.v1;
[Route("api/[controller]")]
[ApiController]
public class ManageUsersController : ControllerBase
{
    /// <summary>
    /// API For user login
    /// </summary>
    /// <param name="loginValidation"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("Login")]
    [ProducesResponseType(typeof(LoginValidationModel), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
    public ActionResult<LoginValidationModel> Login(LoginValidationModel loginValidation, CancellationToken cancellationToken)
    {
        var result = loginValidation;
        var res = ResultHelper.CreateSuccess(result, (int)HttpStatusCode.OK);
        return Ok(res);
    }
}
