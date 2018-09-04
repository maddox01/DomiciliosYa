namespace DomiciliosYa.ViewModels
{
    //view principal del proyecto
    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
