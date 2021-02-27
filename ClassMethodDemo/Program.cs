using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Türkçe)
            // ClassMetotDemo isimli bir proje oluşturunuz. Bunu Github'a aktarınız. Projeniz şunu yapacak.
            // Bir bankada müşteri takibi yapmak istiyorsunuz. Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz.(Id, Ad, Soyad..)
            // MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.


            // (English)
            // Create a project named ClassMethodDemo. Transfer this to Github. Your project will do this.
            // You want to follow up a customer in a bank. Create a Class named Customer. Add the features you want to the customer.(Id, Name, Surname....)
            // Create the CustomerManager class. Simulate methods such as adding, listing, and deleting customers by taking the customer parameter.

            //Aşağıdaki değerler rastgele verilmiş değerlerdir.


            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.TCNo = "12345678916";
            customer1.Name = "Mahsum";
            customer1.Surname = "Yatkı";
            customer1.Age = 25;
            customer1.TelNo = "5555555555";
            customer1.Gender = "E";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.TCNo = "98765432194";
            customer2.Name = "Kemal";
            customer2.Surname = "Kalkan";
            customer2.Age = 23;
            customer2.TelNo = "5554444444";
            customer2.Gender = "E";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.TCNo = "57864127843";
            customer3.Name = "Ayşe";
            customer3.Surname = "Gergin";
            customer3.Age = 22;
            customer3.TelNo = "5553545667";
            customer3.Gender = "K";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                customerManager.CustomerAdd(customer);
            }
            Console.WriteLine("");
            foreach (var customer in customers)
            {
                customerManager.CustomerDelete(customer);
            }
            Console.WriteLine("");
            foreach (var customer in customers)
            {
                customerManager.CustomerList(customer);
            }

        }
    }
}
