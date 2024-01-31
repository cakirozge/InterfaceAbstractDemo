﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))  // puan verdiği için gerçek kişi doğrulaması yapıyor.
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person."); //false dönerse
            }
        }
    }
}
