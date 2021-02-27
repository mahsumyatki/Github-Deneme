using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            if (isTC(customer.TCNo) == false)
            {
                Console.WriteLine("Geçersiz TC No Girdiniz!!");
            }
            else
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " isimli müşteri eklendi...!");
            }   
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " isimli müşteri silindi...!");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.Id +". "+ customer.Name + " " + customer.Surname);
        }

        private bool isTC(string TC)
        {
            bool TCNO = false;
            if (TC.Length == 11)
            {
                int sum = 0;
                for(int i = 0; i < TC.Length-1; i++)
                {
                    sum+=Convert.ToInt32(TC[i])-48;
                }
                if ((sum % 10) != Convert.ToInt32(TC[TC.Length - 1])-48)
                {
                    TCNO = false;
                }
                else
                {
                    TCNO = true;
                }
            }
            else
            {
                TCNO = false;
            }
            
            return TCNO;
        }

    }
}
