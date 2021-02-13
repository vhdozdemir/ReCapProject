using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();

            //UserTest();
            //CustomerTest();

            RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental1 = new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Today };
            Rental rental2 = new Rental { CarId = 2, CustomerId = 2, RentDate = new DateTime(2021, 2, 15), ReturnDate = new DateTime(2021, 2, 20) };
            //rentalManager.Add(rental1);
            //var result = rentalManager.Add(rental2);
            //if (result.Success==true)
            //    Console.WriteLine(result.Message);
            Console.WriteLine("---------------------------- KİRALANAN ARAÇLAR ----------------------------");
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer { UserId = 1, CompanyName = "A" };
            Customer customer2 = new Customer { UserId = 2, CompanyName = "B" };
            //customerManager.Add(customer2);
            //var result = customerManager.Add(customer1);
            //if (result.Success == true)
            //    Console.WriteLine(result.Message);
            //else
            //    Console.WriteLine(result.Message);
            Console.WriteLine("---------------------------- TÜM MÜŞTERİLER ----------------------------");
            var result = customerManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.Id + " " + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user1 = new User { FirstName = "Vahide", LastName = "Özdemir", Email = "vo@gmail.com", Password = "123" };
            User user2 = new User { FirstName = "Ali Osman", LastName = "Özdemir", Email = "aoo@gmail.com", Password = "1234" };
            //userManager.Add(user1);
            //userManager.Add(user2);
            Console.WriteLine("---------------------------- TÜM KULLANICILAR ----------------------------");
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color c1 = new Color { Name = "Siyah" };
            Color c2 = new Color { Name = "Beyaz" };
            Color c3 = new Color { Name = "Gri" };
            Color c4 = new Color { Name = "Kırmızı" };
            Color c5 = new Color { Name = "Lacivert" };
            Color c6 = new Color { Name = "Turuncu" };

            //EKLEME İŞLEMİ
            //colorManager.Add(c1);
            //colorManager.Add(c2);
            //colorManager.Add(c3);
            //colorManager.Add(c4);
            //colorManager.Add(c5);
            //colorManager.Add(c6);
            Console.WriteLine("--------------------------------- TÜM RENKLER ---------------------------------");
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //SİLME İŞLEMİ
            //colorManager.Delete(new Color { Id = 6 });
            //Console.WriteLine("----------------------- SİLİNEN RENK SONRASI TÜM RENKLER ---------------------");
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}

            //GÜNCELLEME İŞLEMİ
            //colorManager.Update(new Color { Id = 1, Name = "SİYAH" });
            //Console.WriteLine("----------------------- GÜNCELLEME RENK SONRASI TÜM RENKLER ---------------------");
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand b1 = new Brand { Name = "Audi" };
            Brand b2 = new Brand { Name = "BMW" };
            Brand b3 = new Brand { Name = "Ford" };
            Brand b4 = new Brand { Name = "Hyundai" };
            Brand b5 = new Brand { Name = "Fiat" };
            Brand b6 = new Brand { Name = "Honda" };
            Brand b7 = new Brand { Name = "Lada" };

            //EKLEME İŞLEMİ
            //brandManager.Add(b1);
            //brandManager.Add(b2);
            //brandManager.Add(b3);
            //brandManager.Add(b4);
            //brandManager.Add(b5);
            //brandManager.Add(b6);
            //brandManager.Add(b7);
            Console.WriteLine("--------------------------------- TÜM MARKALAR ---------------------------------");
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //SİLME İŞLEMİ
            //brandManager.Delete(new Brand { Id = 7 });
            //Console.WriteLine("----------------------- SİLİNEN MARKA SONRASI TÜM MARKALAR ---------------------");
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.Name);
            //}

            //GÜNCELLEME İŞLEMİ
            //brandManager.Update(new Brand { Id = 1, Name = "AUDI" });
            //Console.WriteLine("----------------------- GÜNCELLEME RENK SONRASI TÜM RENKLER ---------------------");
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.Name);
            //}
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { CarName = "A", BrandId = 5, ColorId = 2, DailyPrice = 600, ModelYear = new DateTime(2020, 10, 8) }); -- Araç Eklenmiyor(CarName < 2)
            Car c1 = new Car { CarName = "ArabaBir", BrandId = 1, ColorId = 1, DailyPrice = 300, ModelYear = new DateTime(2013, 2, 5), Description = "Klima Yok - Manuel" };
            Car c2 = new Car { CarName = "ArabaIki", BrandId = 1, ColorId = 2, DailyPrice = 350, ModelYear = new DateTime(2014, 2, 20), Description = "Klima Yok - Manuel" };
            Car c3 = new Car { CarName = "ArabaUc", BrandId = 2, ColorId = 2, DailyPrice = 350, ModelYear = new DateTime(2015, 3, 11), Description = "Klima Yok - Manuel" };
            Car c4 = new Car { CarName = "ArabaDort", BrandId = 3, ColorId = 2, DailyPrice = 400, ModelYear = new DateTime(2016, 6, 6), Description = "Klima Yok - Otomatik" };
            Car c5 = new Car { CarName = "ArabaBes", BrandId = 4, ColorId = 3, DailyPrice = 500, ModelYear = new DateTime(2017, 8, 16), Description = "Klima Var - Otomatik" };
            Car c6 = new Car { CarName = "ArabaAlti", BrandId = 5, ColorId = 4, DailyPrice = 550, ModelYear = new DateTime(2018, 10, 8), Description = "Klima Var - Otomatik" };
            Car c7 = new Car { CarName = "ArabaYedi", BrandId = 1, ColorId = 1, DailyPrice = 600, ModelYear = new DateTime(2019, 10, 8), Description = "Klima Var - Otomatik" };
            Car c8 = new Car { CarName = "ArabaSekiz", BrandId = 5, ColorId = 4, DailyPrice = 650, ModelYear = new DateTime(2020, 10, 8), Description = "Klima Yok - Otomatik" };
            //EKLEME İŞLEMİ
            //carManager.Add(c1);,
            //carManager.Add(c2);
            //carManager.Add(c3);
            //carManager.Add(c4);
            //carManager.Add(c5);
            //carManager.Add(c6);
            //carManager.Add(c7);
            //carManager.Add(c8);
            Console.WriteLine("--------------------------------- TÜM ARAÇLAR ---------------------------------");
            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //SİLME İŞLEMİ
            //carManager.Delete(new Car { Id = 8 });
            //Console.WriteLine("----------------------- SİLİNEN ARAÇ SONRASI TÜM ARAÇLAR ---------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //GÜNCELLEME İŞLEMİ
            //carManager.Update(new Car { Id = 7, CarName = "ArabaYedi", BrandId = 1, ColorId = 2, Description = "Klima Var - Otomatik", ModelYear = new DateTime(2021, 1, 9), DailyPrice = 700 });
            //Console.WriteLine("----------------------- GÜNCELLENEN ARAÇ SONRASI TÜM ARAÇLAR ---------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}

            Console.WriteLine("---------------------- MARKASI AUDI (ID -1) OLAN ARAÇLAR ----------------------");
            var result2 = carManager.GetCarsByBrandId(1);
            if (result2.Success == true)
            {
                foreach (var car in result2.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }

            Console.WriteLine("---------------------- RENGİ BEYAZ (ID -2) OLAN ARAÇLAR ----------------------");
            var result3 = carManager.GetCarsByColorId(2);
            if (result3.Success == true)
            {
                foreach (var car in result3.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result3.Message);
            }
            Console.WriteLine("-------------------------------- ARAÇ DETAYLARI --------------------------------");
            var result4 = carManager.GetCarDetails();
            if (result4.Success == true)
            {
                foreach (var car in result4.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result4.Message);
            }
        }
    }
}
