namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string tc_no { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public string Password { get; set; } = default!;

}