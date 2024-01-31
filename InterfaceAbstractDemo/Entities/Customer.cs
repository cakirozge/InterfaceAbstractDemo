using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }


    }
}

//SENARYO
//kAHVE DÜKKANLARI İÇİN MÜŞTERİ YÖNETİMİ YAPAN BİR SİSTEM YAZMAK İSTİYORUZ.
//Starbucks ve Nero firması için çalışıyoruz.
//İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//Starbucks müşteri kaydederken, mutlaka mernis doğrulaması istiyor.
//Nero müşterileri kaydederken böyle bir şey istemiyor.
//Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.