namespace Vladify.BusinessLogic.Models;

public class ErrorDetails
{
    public string ErrorTitle { get; set; } = "An error occured while processing the request";
    public required string ErrorMessage { get; set; }
    public int StatusCode { get; set; }
}
