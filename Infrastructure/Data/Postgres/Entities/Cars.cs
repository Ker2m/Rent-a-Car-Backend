using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Cars : Entity<int>
{
    public string arac_adi { get; set; } = default!;
    public string arac_resmi { get; set; } = default!;
    public string vites_tipi { get; set; } = default!;
    public string yakit_tipi { get; set; } = default!;
    public int arac_kilometre { get; set; } = default!;
    public string arac_tipi { get; set; } = default!;
    public int arac_koltuk { get; set; } = default!;
    public string arac_popularite { get; set; } = default!;
    public int price { get; set; } = default!;

    public ICollection<Comment> Comments { get; set; }
    public ICollection<Reservations> Reservations { get; set; }

}
