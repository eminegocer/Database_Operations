
using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using consoleApp.Data.EfCore;


namespace consoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // InsertUsers();
            // InsertAddresses();
            //using (var db = new ShopContext())

            // {
            //     var user = db.Users.FirstOrDefault(i => i.UserName == "goktuggocer");

            //     if (user != null)
            //     {
            //         user.Adresses = new List<Address>();
            //         user.Adresses.AddRange(
            //                         new List<Address>(){
            //                         new Address(){FullName = "göktuğ gocer", Title="İş Adresi 1", Body="Kocaeli" },
            //                         new Address(){FullName = "göktuğ gocer", Title="İş Adresi 2", Body="Kocaeli" },
            //                         new Address(){FullName = "göktuğ gocer", Title="İş Adresi 3", Body="Kocaeli" },
            //                         new Address(){FullName = "göktuğ gocer", Title="İş Adresi 4", Body="Kocaeli"}

            //                         }
            //                     );
            //         db.SaveChanges();
            //     }
            //  }


            using (var db = new ShopContext())
            {
                // var customer=new Customer(){
                //     IdentityNumber="12121325",
                //     FirstName="emine",
                //     LastName="gocer",
                //     User=db.Users.FirstOrDefault(i => i.Id ==3)
                // };
                // db.Customers.Add(customer);
                // db.SaveChanges();

                //     var user =new User(){
                //         UserName ="deneme",
                //         Email="deneme@gmail.com",
                //         Customer=new Customer()
                //         {
                //             FirstName="deneme",
                //             LastName="deneme",
                //             IdentityNumber="12345"
                //         }
                //     };
                //     db.Users.Add(user);
                //     db.SaveChanges();
                // }

                //         var products = new List<Product>
                //     {
                //         new Product(){Name ="Samsung S5", Price = 2000},
                //         new Product(){Name ="Samsung S6", Price = 3000},
                //         new Product(){Name ="Samsung S7", Price = 4000},
                //         new Product(){Name ="Samsung S8", Price = 5000}
                //     };


                // var categories = new List<Category>()
                // {
                //     new Category(){Name="Telefon"},
                //     new Category(){Name="Elektronik"},
                //     new Category(){Name="Bilgisayar"}
                // };

                // int[]ids = new int[2]{1,2};
                // var p = db.Products.Find(1);

                // p.ProductCategories = ids.Select(cid => new ProductCategory()
                // {
                //     CategoryId = cid,
                //     ProductId = p.Id
                // }).ToList();

                // db.SaveChanges();

                // var p = new Product()
                // {
                //     Name = "Samsung S6",
                //     Price = 2000
                // };

                // var  p = db.Products.FirstOrDefault(p => p.Id==1);

                // p.Name = "Samsung S11";
                // db.SaveChanges();


            }
            // DataSeeding.Seed(new ShopContext());

            using (var db = new NorthwindContext())
            {
                // Tüm müşteri kayıtlarıı

                // var customers = db.Customers.ToList();

                // foreach(var item in customers)
                // {
                //     Console.WriteLine(item.FirstName + " " + item.LastName);
                // }



                // sadece firs_name ve last_name

                // var customers = db.Customers
                //                   .Select(c => new {
                //                     c.FirstName,
                //                     c.LastName
                //                   });

                // foreach(var item in customers)
                // {
                //     Console.WriteLine(item.FirstName + " " + item.LastName);
                // }


                // New York ta yasayanlar
                // var customers = db.Customers.Where(i => i.City == "New York").Select(s => new {s.FirstName,s.LastName}).ToList(); 


                //Beverages katagorisindeki ürünler
                //var productnames = db.Products.Where(i => i.Category =="Beverages").Select(s => s.ProductName}).ToList();

                // son eklenen 5 ürübn
                // var products = db.Products.OrderByDescending(i => i.Id).Take(5).ToList();

                //fiyatı 10-30 isim ve fiyatları
                // var products = db.Products.Where(i => i.ListPrice>10 && i.ListPrice<30).Select(i => new{i.ProductName, i.ListPrice}).ToList();


                // beverages kategorisindeki ürünlerin ortalaması
                // var products = db.Products.Where(i => i.Category == "Beverages").Average(i=> i.ListPrice);

                // beverages kategorisindeki ürünlerin sayısı
                //var products = db.Products.Where(i => i.Category =="Beverages").Count();
                //var products = db.Products.Count(i => i.Category =="Beverages");


                // beverages ve condimenta kategorisindeki ürünlerin toplam fiyatı
                // var sum = db.Products.Where(i => i.Category == "Beverages" || i.Category =="Condiments").Sum(i => i.ListPrice);

                //Tea kelimesini içeren urunler
                //var products = db.Products.Where(i => i.ProductName.Contains("Tea")).Select(i => i.ProductName).ToList();


                //en pahalı ve en ucuz urun
                // var result = db.Products.Min(i => i.ListPrice);
                // var result2 = db.Products.Max(i => i.ListPrice);


                var customers = db.Customers.Where(i => i.Orders.Count()>0).Select(i => i.FirstName).ToList();

                foreach(var item in customers)
                {
                    Console.WriteLine(item);
                }
                
            }
        }

        public static void InsertUsers()
        {
            var users = new List<User>()
            {
                new User(){UserName = "eminegocer", Email="info@eminegocer"},
                new User(){UserName = "semagocer", Email="info@semagocer"},
                new User(){UserName = "gamzegocer", Email="info@gamzegocer"},
                new User(){UserName = "goktuggocer", Email="info@goktuggocer"},
            };


            using (var db = new ShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }
        public static void InsertAddresses()
        {
            var addresses = new List<Address>()
            {
                new Address(){FullName = "emine gocer", Title="Ev Adresi", Body="Elaziğ",UserId=1},
                new Address(){FullName = "sema gocer", Title="İş Adresi", Body="Hatay",UserId=2},
                new Address(){FullName = "gamze gocer", Title="Ev Adresi", Body="Mersin",UserId=3},
                new Address(){FullName = "göktuğ gocer", Title="İş Adresi", Body="Kocaeli",UserId=4},
                new Address(){FullName = "gülsüm gocer", Title="Ev Adresi", Body="Gaziantep",UserId=1},
                new Address(){FullName = "canan gocer", Title="Ev Adresi", Body="Kocaeli",UserId=3},
            };


            using (var db = new ShopContext())
            {
                db.Adresses.AddRange(addresses);
                db.SaveChanges();
            }
        }

    }
    //context sınıfı
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Adresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            //.UseSqlite("Data Source = shop.db");
            //.UseSqlServer(@"Server = EMINEGOCER\SQLEXPRESS; Database = ShopDb; Integrated Security = SSPI;TrustServerCertificate=True;");
            .UseMySql(@"server = localhost;port =3306; database = ShopDb; user=root; password=mysql1234", new MySqlServerVersion(new Version(8, 0, 2)));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasIndex(u => u.UserName)
                        .IsUnique();

            modelBuilder.Entity<Product>()
                        .ToTable("Ürünler");

            modelBuilder.Entity<Customer>()
                        .Property(p => p.IdentityNumber)
                        .HasMaxLength(10)
                        .IsRequired();

            modelBuilder.Entity<ProductCategory>()
                        .HasKey(t => new { t.ProductId, t.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                        .HasOne(pc => pc.Product)
                        .WithMany(p => p.ProductCategories)
                        .HasForeignKey(pc => pc.ProductId);


            modelBuilder.Entity<ProductCategory>()
                        .HasOne(pc => pc.Category)
                        .WithMany(c => c.ProductCategories)
                        .HasForeignKey(pc => pc.CategoryId);
        }

    }
    public static class DataSeeding
    {
        public static void Seed(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context is ShopContext)
                {
                    ShopContext _context = context as ShopContext;

                    if (_context.Products.Count() == 0)
                    {
                        _context.Products.AddRange(Products);
                    }
                    if (_context.Categories.Count() == 0)
                    {
                        _context.Categories.AddRange(Categories);

                    }
                }
                context.SaveChanges();
            }

        }

        private static Product[] Products ={
            new Product(){Name="Samsung S6",Price = 2000},
            new Product(){Name="Samsung S7",Price = 5000},
            new Product(){Name="Samsung S8",Price = 3000},
            new Product(){Name="Samsung S9",Price = 4000}
        };

        private static Category[] Categories ={
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"},
        };
    }
    // entity sınıfları
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Inserted { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
        public List<ProductCategory> ProductCategories { get; set; }


    }
    // entity sınıfları
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }

    //[NotMapped]
    [Table("ÜrünKategorileri")]
    public class ProductCategory
    {

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(8), MaxLength(15)]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Email { get; set; }
        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
        public List<Address> Adresses { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }

    public class Customer
    {
        [Column("customer_id")]
        public int Id { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }




    public class Methods
    {


        static void DeleteProduct(int id)
        {
            using (var context = new ShopContext())
            {
                var p = new Product() { Id = 3 };
                context.Products.Remove(p);
                context.SaveChanges();


                // var p = context.Products
                //                .FirstOrDefault(i => i.Id == id);
                // if(p !=null)
                // {
                //     context.Remove(p);

                //     context.SaveChanges();

                //     Console.WriteLine("veri silindi");
            }
        }

        static void UpdateProduct()
        {
            using (var context = new ShopContext())
            {
                var p = context.Products.Where(i => i.Id == 1)
                               .FirstOrDefault();

                if (p != null)
                {
                    p.Price = 2500;
                    context.Products.Update(p);
                    context.SaveChanges();
                }
            }




            // using(var context = new ShopContext())
            // {
            //     var p = new Product{Id = 1};
            //     context.Products.Attach(p);
            //     p.Price = 3000;
            //     context.SaveChanges();
            // }



            using (var context = new ShopContext())
            {
                var p = context.Products
                        //.AsNoTracking()
                        .Where(i => i.Id == 1)
                        .FirstOrDefault();

                if (p != null)
                {
                    p.Price *= 1.2;
                    context.SaveChanges();

                    Console.WriteLine("güncelleme yapıldı");
                }

            }
        }
        static void GetProductByName(string name)
        {
            using (var contex = new ShopContext())
            {
                var result = contex.Products
                               .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                               .Select(product => new
                               {
                                   product.Name,
                                   product.Price
                               })
                               .ToList();

                foreach (var p in result)
                {
                    Console.WriteLine($"{p.Name} {p.Price}");
                }
            }
        }
        static void AddProducts()
        {
            using (var db = new ShopContext())
            {
                var products = new List<Product>()
                {
                    new Product{Name = "Samsung S5", Price = 2000},
                    new Product{Name = "Samsung S6", Price = 3000},
                    new Product{Name = "Samsung S7", Price = 4000},
                    new Product{Name = "Samsung S8", Price = 5000},
                    new Product{Name = "Samsung S9", Price = 6000},
                };

                db.Products.AddRange(products);
                db.SaveChanges();

                Console.WriteLine("veriler eklendi");
            }
        }

        static void GetAllProducts()

        {
            using (var context = new ShopContext())
            {
                var products = context
                .Products
                .ToList();

                foreach (var p in products)
                {
                    Console.WriteLine($"name:{p.Name} price:{p.Price} ");
                }


            }
        }

        static void GetProductById(int id)
        {
            using (var context = new ShopContext())
            {
                var result = context
                    .Products
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

                Console.WriteLine($"name:{result.Name} price:{result.Price} ");
            }

        }

    }
}