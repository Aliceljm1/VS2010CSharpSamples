﻿// 版权所有(C) Microsoft Corporation。保留所有权利。
// 此代码的发布遵从
// Microsoft 公共许可(MS-PL，http://opensource.org/licenses/ms-pl.html)的条款。


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BdcSampleCSharp;

namespace BdcSampleCSharp.BdcModel1
{
    public partial class CustomerService
    {
        
        public static Customer ReadItem(string customerID)
        {
            CustomerDataContext context = new CustomerDataContext();

            Customer cust = context.Customers.Single(c => c.CustomerID == customerID);

            return cust;

        }

        public static IEnumerable<Customer> ReadList()
        {
            CustomerDataContext context = new CustomerDataContext();

            IEnumerable<Customer> custList = context.Customers;

            return custList;

        }

        public static Customer Create(Customer newCustomer)
        {
            CustomerDataContext context = new CustomerDataContext();

            context.Customers.InsertOnSubmit(newCustomer);
            context.SubmitChanges();

            Customer cust = context.Customers.Single(c => c.CustomerID == newCustomer.CustomerID);

            return cust;

        }

        public static void Delete(string customerID)
        {
            CustomerDataContext context = new CustomerDataContext();

            Customer cust = context.Customers.Single(c => c.CustomerID == customerID);

            context.Customers.DeleteOnSubmit(cust);
            context.SubmitChanges();

        }


        public static void Update(Customer customer, string customerID)
        {
            CustomerDataContext context = new CustomerDataContext();

            Customer cust = context.Customers.Single(c => c.CustomerID == customer.CustomerID);

            cust.CustomerID = customer.CustomerID;   
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.CompanyName = customer.CompanyName;
            cust.ContactName = customer.ContactName;
            cust.ContactTitle = customer.ContactTitle;
            cust.Country = customer.Country;
            cust.Fax = customer.Fax;
            cust.Phone = customer.Phone;
            cust.PostalCode =customer.PostalCode;
            cust.Region = customer.Region;
            
            context.SubmitChanges();

        }
    }
}
