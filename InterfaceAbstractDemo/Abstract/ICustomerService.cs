using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
        //interface implemetasyonu yapan herkes save operasyonunu kullanmak zorundadır !
    {
        void Save(Customer customer);
    }
}
