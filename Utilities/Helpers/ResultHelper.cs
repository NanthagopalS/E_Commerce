using Utilities.Models;

namespace Utilities.Helpers;
public static class ResultHelper
{
    public static ResultModel CreateSuccess(dynamic data, int statusCode)
    {
        var result = new ResultModel()
        {
            Data = data,
            StatusCode = statusCode.ToString(),
            Message = "Success"
        };
        return result;
    }
}
