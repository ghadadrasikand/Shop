using Microsoft.Extensions.Options;
using Shop.Host.ApplicationServices.IServices;
using Shop.Host.DTOs.Products;
using Shop.Host.Extensions;
using Shop.Host.Inferastructure.IRepositories;
using Shop.Host.Models;
using Shop.Host.Models.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Host.ApplicationServices.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly CDNConfig CDNConfig;
        public ProductService(IProductRepository repository, IOptions<CDNConfig> cDNConfig)
        {
            _repository = repository;
            CDNConfig = cDNConfig.Value;

        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public GridResultDTO GetPaging(int skip, int take)
        {
            int count = _repository.GetCount();
            var data = _repository.GetPaging(skip, take);

            var productDTO = data.Select(x => new ProductListDTO
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                ImagePath = x.ImagePath
            }).ToList();

            return new GridResultDTO(count, productDTO);
        }

        public bool Insert(ProductInsertDTO dto)
        {
            bool result = false;
            var imagePath = ImageExtension.SaveToCdn(dto.Img, CDNConfig.Cdn, CDNConfig.Path);
            var pr = new Product()
            {
                Name = dto.Name,
                Price = dto.Price,
                Quantity = dto.Quantity,
                ImagePath = imagePath
            };

            int inserted = _repository.Insert(pr);
            if (inserted > 0)
            {
                result = true;
            }
            return result;
        }

        public bool Insert(ProductPanelInsertDTO dto)
        {
            bool result = false;
            //var imagePath = ImageExtension.SaveToCdn(dto.Img, CDNConfig.Cdn, CDNConfig.Path);
            var pr = new Product()
            {
                Name = dto.Name,
                Price = dto.Price,
                Quantity = dto.Quantity,
                //ImagePath = imagePath
            };

            int inserted = _repository.Insert(pr);
            if (inserted > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
