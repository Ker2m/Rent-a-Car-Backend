using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string tc_no { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Reservations> Reservations { get; set; }
}

//denemecadas
//rent-a-car-backend isim denemesi (repository ismini github üzerinden değiştirdim)

public enum UserType
{
    Admin,
    User,
}