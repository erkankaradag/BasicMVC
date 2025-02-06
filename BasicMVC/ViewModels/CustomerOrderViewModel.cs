using BasicMVC.Models;

namespace BasicMVC.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
