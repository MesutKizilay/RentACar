﻿using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public IResult AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
