namespace DomiciliosYa.Backend.Models
{
    using DomiciliosYa.Domain.Models;

    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<DomiciliosYa.Common.Models.Products> Products { get; set; }
    }
}