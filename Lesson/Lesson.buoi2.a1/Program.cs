// See https://aka.ms/new-console-template for more information

namespace Lesson.buoi2.a1;
class Program
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public class ProductDto
    {
        public string ProductName { get; set; } = "";
        public decimal ProductPrice { get; set; }
        public string Category { get; set; } = "";
    }
    static void Main(string[] args)
    {
        
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone 15", Price = 25000, Category = "Điện thoại" },
            new Product { Id = 2, Name = "Samsung S24", Price = 22000, Category = "Điện thoại" },
            new Product { Id = 3, Name = "MacBook Air", Price = 32000, Category = "Laptop" },
            new Product { Id = 4, Name = "Dell XPS", Price = 28000, Category = "Laptop" },
            new Product { Id = 5, Name = "AirPods Pro", Price = 6500, Category = "Phụ kiện" },
            new Product { Id = 6, Name = "Galaxy Buds", Price = 4500, Category = "Phụ kiện" }
        };

        
        // lINQ, 1 trong nhung cong cu manh me nhat cua C# de xu ly du lieu
            // phan core, cai nay ma khong biet la khong lam .NET
            
        // LINQ (Language Integrated Query) la mot phan cua .NET framework,
        // cung cap 1 cach tiep can manh me 
        // va linh hoat de truy van va thao tac du lieu tu
        // nhieu nguon khac nhau nhu (Collections, database, XML,...)
        // bang cach su dung cu phap giong nhu SQL nhung tich hop truc tiep
        // vao ngon ngu lap trinh C#
        
        /*
         * Truoc day khi chua co LINQ?
         * - Muong query database -> viet SQL
         * - Muon loc 1 danh sach -> thi viet vong For - Sau do If Else de lay ra
         * - Voi moi nguon du lieu, phai su dung nhung cach rieng biet khac nhau
         * 
         * Sau khi co LINQ
         * - Viet truy van db = C# luon
         * - Viet 1 kieu thoi, nhung ma kieu nay co the truy van tu nhieu nguon (SQL, Collection)
         */

        List<int> list = [1, 2, 2, 3, 4];
        List<int> list2 = []; // lay ra mang cac so chan
        // Truoc khi su dung LINQ
        foreach (var item in list)
        {
            if(item % 2 == 0)
            {
                list2.Add(item);
            }
        }
        
        // sau khi su dung lINQ
        list2 = list.Where(x => x % 2 == 0).ToList();
        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }
        
        // LINQ co 2 dang chinh: LINQ to Object, LINQ to SQL
        // LINQ to Object:
            // Dung de query cac Collection: List, Array, Dictionary,...
            //list2 = list.Where(x => x % 2 == 0).ToList();
            
        // LINQ to SQL 
            // LINQ + Entity Framework ket hop lai, de query database
            // Giup nguoi dung co the truy van du lieu bang ngon ngu C# luon
            // Khi minh viet code C#, EF se convert code C# do sang SQL giup minh
            // Vi du: _dbContext.Users.Where(x => x.FirstName.Contains("abc"))
            
        // Cac loi ich cua viet LINQ: 
            // De doc, de hieu, Viet 1 kieu thoi, nhung kieu nay co the truy van tu nhieu ngion
            // de dang trong viec phat trien, giam truy van sai
                //Khi minh viet SQL, thi no la string ma
                    // co the viet sai chinh ta (sai ten cot, ten table)
                    
                // con khi minh viet bang code, thi cac cot la cac field trong class
                    // chi viec cham ra xai thoi, khong can care chinh ta
                // trong LINQ, muon truy van theo dieu kien nao thi cham ra xai thoi.
        
        // Co 2 truong phai viet LINQ
        /*
         * 1. LINQ Query Syntax (Cu phap truy van)
         *          Kieu nay thi no giong het SQL, nhung viet trong C#
         * var result = from p in products where p.Name.Contain("%abc$")
         * 2. LINQ Method Syntax (Cu phap truy van)
         * var result = products.Where(p => p.Name.Contain("abc"));
         */
            
        // ***** DEFERRED EXECUTION (Lazy Loading) & Immediate Execution (Eager Loading) *****
        /*
         * DEFERRED EXECUTION (Lazy Loading)
         * - LINQ se khong chay ngay khi ban vua viet xong
         * - No chi ho tro xay dung 1 bieu thuc (Expression) - 1 bang ke hoach
         * - Va cho den khi ban duyet (Integrate) thi no moi thuc thi bang ke hoach
         *  + Tu duyet (Integrate) nay the hien o nhung cho nao. For, ForEach 
         */
        
        List<int> demoDeferredExecution = [1, 2, 2, 3, 4];
        var filters = demoDeferredExecution.Where(x => x % 2 == 0).ToList();
        demoDeferredExecution.Add(6);
        foreach (var item in filters)
        {
            Console.WriteLine(item);
        }
        // 2, 4, 6
        // filters no la 1 bang ke hoach, cho doi de duoc duyet va tra ra ket qua
        // cond oi' voi tuong tac DB, thi no duoc coi la 1 cau
            // query nong hoi vua duoc viet ra nhung chua duoc thuc thi
            
            /*
             * Deferred Query Operators phổ biến
             * - Where - truy van dieu kien
             * - Select - truy van de lay ra 1 kieu du lieu khac (projection)
             * - OrderBy, OrderByDescending - sap xep thu tu cua du lieuj
             * - GroupBy - nhom du lieu theo 1 tieu chi nao do
             * - Join - ket hop du lieu tu 2 nguon khac nhau
             * - Skip, SkipWhile - Bo qua
             * - Take, TakeWhile - Lay ...? Giai thich phan trang.........................?
             * - Distinct
             *
             * -> Mấy thằng trên trả về IEnumerable hoặc IQueryable // Trong tương lai sẽ biết
             */
            
            /*
             * Immediate Execution (Eager Loading)
             * - Query trả ra kết quả ngay lập tức khi gọi phương thức
             *
             * Chỉ có ít số ít các phương thức sẽ kích hoạt việc thực thi Query
             * ToList(), ToArray(), ToDictionary(), Count(), ... Trả ra 1 collection hoặc 1 giá trị (Count) ngay lập tức
             * FirstOrDefault(), First(), SingleOrDefault(), Single(), ... Trả ra phần tử đầu tiên
             */
                
        // Where, Dung de truy van du lieu
            // Lay ra san pham nao co category la Dien thoai
            var phoneList = products.Where(p => p.Category == "Dien Thoat").ToList();
            
            // Lay ra san pham co gia tri lon hon 20k
            var phoneList2 = products.Where(p => p.Price > 20000).ToList();
            
            // lay ra san pham la dien thoai va co gia lon hon 20k
            var phoneList3 = products.Where(p => p.Price > 30000 && p.Category == "Dien Thoai").ToList();
            
            
    }
    
}

