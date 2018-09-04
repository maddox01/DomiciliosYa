namespace DomiciliosYa.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<DomiciliosYa.Common.Models.Product> Products { get; set; }
    }
}
