using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", Id = 1, NationalityId = "123454555555" });
            Console.ReadLine();
          
        }
    }
}

//SENARYO
//kAHVE DÜKKANLARI İÇİN MÜŞTERİ YÖNETİMİ YAPAN BİR SİSTEM YAZMAK İSTİYORUZ.
//Starbucks ve Nero firması için çalışıyoruz.
//İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//Starbucks müşteri kaydederken, mutlaka mernis doğrulaması istiyor.
//Nero müşterileri kaydederken böyle bir şey istemiyor.
//Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.