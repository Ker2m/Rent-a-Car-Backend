using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string tc_no { get; set; } = default!;
    public string userName { get; set; } = default!;
    public string email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public UserType UserType { get; set; }
}