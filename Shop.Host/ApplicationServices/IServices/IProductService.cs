using Shop.Host.DTOs.Products;
using Shop.Host.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Host.ApplicationServices.IServices
{
    public interface IProductService
    {
        List<Product> GetAll();
        GridResultDTO GetPaging(int skip, int take);
        bool Insert(ProductInsertDTO dto);
        bool Insert(ProductPanelInsertDTO dto);
    }
}
