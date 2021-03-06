using System.ComponentModel.DataAnnotations;

namespace Shop.Host.DTOs.Products
{
    public class ProductPanelInsertDTO
    {
        [Required(ErrorMessage = "فیلد نام نمیتواند خالی باشد"),
            StringLength(128, ErrorMessage = "طول فیلد نام باید حداکثر 128 کاراکتر باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "فیلد قیمت نمیتواند خالی باشد"),
            Range(1, int.MaxValue, ErrorMessage = "باید بین 1 تا یک عدد 10 رقمی باشد")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "فیلد تعداد نمیتواند خالی باشد"),
             Range(1, int.MaxValue, ErrorMessage = "باید بین 1 تا یک عدد 10 رقمی باشد")]
        public int Quantity { get; set; }
        //public IFormFile Img { get; set; }
    }


}
