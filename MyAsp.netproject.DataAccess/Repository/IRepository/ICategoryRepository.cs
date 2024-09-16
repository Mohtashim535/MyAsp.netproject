using MyAsp.netproject.Models;
using MyAsp.NetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAsp.netproject.DataAccess.Repository.IRepository
{
    
    
        public interface IProductRepository : IRepository<Product>
        {
            void Update(Product obj);
            
        }

    
}
