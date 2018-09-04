namespace DomiciliosYa.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name ="Nombre Comida")]
        public string NameProduct { get; set; }

        [Display(Name = "Descripción Comida")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        public Decimal PriceProduct { get; set; }

        [Display(Name = "Existencia")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Fecha Publicación")]
        public DateTime PublishOn { get; set; }

        public override string ToString()
        {
            return this.NameProduct;
        }
    }
}
