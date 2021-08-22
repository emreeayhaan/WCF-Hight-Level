 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFHightLevel.Dto
{
    //Kullanıcının bilgilerini(ID,ProductId,Price,Stock ve ImageBase)görüntülemek ve kullanmak için oluşturduğumuz DTO class'ı.
    public class ProductDto
    {
        public int ProducttId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string ImageBase64 { get; set; }
    }
}