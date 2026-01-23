namespace Vladify.BusinessLogic.Models;

public class ErrorDetails
{
    public string ErrorTitle { get; set; } = "An error occured while processing the request";
    public required string ErrorMessage { get; set; }
    public required int StatusCode { get; set; }
}
