using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wms.Data.Entities;
using Wms.Repo;
using Wms.Service.Interfaces;
using Wms.Service.Models;

namespace Wms.Service.Services.Customer
{
    public static class CustomerExtension
    {
        public static IQueryable<CustomerModel> QueryModel(this IQueryable<CCustomer> query)
        {
            return query.Select(item => new CustomerModel()
            {
                CustomerType =  item.CustomerType,
                Website =  item.Website,
                CompanyName = item.CompanyName,
                Email = item.Email,
                FirstName = item.FirstName,
                Id = item.Id,
                LastName = item.LastName,
                Mobile = item.Mobile,
                Salutation = item.Salutation,
                WorkPhone = item.Salutation
            });
        }

    }
}
