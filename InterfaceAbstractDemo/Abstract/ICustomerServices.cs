using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
   public interface ICustomerServices
    {
        //iki müşteride de bu operasyonlar var ise bunu mutlaka soyutlamalıyız.
         public void Save(Customer customer); //bu operasyonu kullanan herkes implemente etmelidir.
    }
}
