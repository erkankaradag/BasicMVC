# BasicMVC Projesi

**BasicMVC** projesi, ASP.NET Core MVC kullanarak bir müşteri ve sipariş bilgilerini görüntülemek için geliştirilmiş basit bir web uygulamasıdır. Bu proje, temel model-view-controller (MVC) yapısını kullanarak müşteri ve sipariş bilgilerini birleştirip görüntülemeyi amaçlamaktadır.

## Proje İçeriği

- **Customer** modeli: Müşteri bilgilerini tutar (Id, FirstName, LastName, Email).
- **Order** modeli: Sipariş bilgilerini tutar (Id, ProductName, Price, Quantity).
- **CustomerOrderViewModel**: Müşteri ve siparişleri birleştiren ViewModel.
- **CustomerOrdersController**: Müşteri ve sipariş verilerini alır ve bunları **Index** view'ına iletir.
- **Index.cshtml**: Müşteri ve sipariş bilgilerini görüntüleyen view.

## Kurulum

Bu projeyi yerel bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz.

### Gereksinimler
- .NET 6.0 veya daha yüksek bir sürüm (ASP.NET Core 6.0 ve sonrası)
- Visual Studio veya Visual Studio Code (isteğe bağlı)

### Adım 1: Projeyi İndirme

Bu projeyi Git ile veya dosyayı indirerek bilgisayarınıza alabilirsiniz.

```bash
git clone https://github.com/yourusername/BasicMVC.git

### Dosya Yapısı
/BasicMVC
│
├── Controllers
│   └── CustomerOrdersController.cs   # Müşteri ve sipariş bilgilerini yöneten denetleyici
│
├── Models
│   ├── Customer.cs                  # Customer model sınıfı
│   └── Order.cs                     # Order model sınıfı
│
├── Views
│   └── CustomerOrders
│       └── Index.cshtml             # Müşteri ve sipariş bilgilerini görüntüleyen view
│
├── ViewModels
│   └── CustomerOrderViewModel.cs    # Müşteri ve siparişleri birleştiren ViewModel
│
├── Program.cs                       # Uygulamanın giriş noktası ve yapılandırma
└── Startup.cs                       # Uygulama yapılandırma ve servis tanımları
