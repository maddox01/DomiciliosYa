//instanmciar la mainviewmodel
namespace DomiciliosYa.infrastructure
{
    using DomiciliosYa.ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
