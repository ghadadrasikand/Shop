using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Host.ApplicationServices.IServices;
using Shop.Host.DTOs.Products;
using Shop.Host.Models;

namespace Shop.Host.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class ProductPanelController : Controller
    {
        private readonly IProductService ProductService;
        public ProductPanelController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var result = ProductService.GetPaging(0, 20);
            return View(result);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(ProductPanelInsertDTO dto)
        {
            if (ModelState.IsValid)
            {
                var result = ProductService.Insert(dto);
                if (result)
                {
                    return RedirectToAction("ProductList");
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                return View("AddProduct",dto);
            }
           
        }



        //[HttpGet]
        //[Route("{skip}/{take}")]
        //public IActionResult ProductList(int skip, int take)
        //{
        //    var result = ProductService.GetPaging(skip, take);
        //    return View(result);
        //}
    }
}