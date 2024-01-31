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
            //yıla göre doğrulama yapıyor. doğum yılınızı doğru giriniz ve gerçek isim, soyisim tc kullanın.
            //yanlış girdiğinizde invalid duracaktır.
            //
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995, 8, 15), FirstName = "Özge", LastName = "Çakır", Id = 1, NationalityId = "Kendi TC Kimlik No girin" });
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