// Veri Yükleme Stratejileri (Loading Types)

/*
 * Eager Loading: İlişkili verilerin ana veri ile birlikte yüklenmesi anlamına gelir. Bu yaklaşım, veri çekme işlemi sırasında bir defada tüm verilerin alınmasını sağlar.
 * 
 * Eager Loading veritabanı erişimlerini minimize etmek, için tek bir sorgu ile birden fazla tabloyu birleştirerek çalışır.
 */

using EFCore_Loading_DataAnnotations;
using Microsoft.EntityFrameworkCore;

AppDbContext context = new AppDbContext();
// 1. Eager Loading tüm verilerin aynı anda yüklenmesini sağladığı için ilişkili tablolarla işlem yapacaksa Include anahtar kelimesiyle ilişkili olan tabloyu üzerinden sorgu yazdığımız tabloya dahil etmek zorundayız. Bu dahil etme işlemi Include ile sağlanır.

//var customer = context.Customers.Include(x => x.Orders).FirstOrDefault(x => x.CustomerId == 1);

//var berkayOrders = customer.Orders;

//foreach (var item in berkayOrders)
//{
//    Console.WriteLine(item.Number);
//}

// 2. Lazy Loading: İlişkili verilerin ihtiyaç duyulana kadar yüklenmemesi anlamına gelir. Bu yöntem belleği daha verimli kullanmak ve performansı arttırmak amacıyla kullanılabilir. Yalnızca gerçekten erişildiğinde ilişkili veriler veritabanından çekilir.
// Eğer Lazy Loading kullanmak istiyorsak en önemli anahtar kelime class ın içindeki property virtual anahtar kelimesi yazılmalıdır.
// Bu yöntem büyük veri setlerinde gereksiz veri yüklemeyi önleyebilir ancak her veri erişiminde veritabanına sorgu atılacağı için kullanıcının performansa dikkat etmesi gerekir.

//var customer = context.Customers.FirstOrDefault(x => x.CustomerId == 1);

//var customerOrders = customer.Orders;

//foreach (var item in customerOrders)
//{
//    Console.WriteLine(item.Number);
//}

// 