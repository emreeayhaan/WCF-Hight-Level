using Data.Database;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFHightLevel.Dto;
using WCFHightLevel.Interfaces;

namespace WCFHightLevel.Services
{
    public class ProductService : IProductService
    {
        public string AddProduct(ProductDto product)
        {
            try
            {
                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {

                    product product1 = new product();
                    product1.ProductId = product.ProducttId;
                    product1.ProductName = product.ProductName;
                    product1.Price = product.Price;
                    product1.Stock = product.Stock;
                    product1.ImageBase64 = product.ImageBase64;
                    uow.Repository<product>().Add(product1);
                    //uow.Repository<Product>().GetAll();
                    uow.Save();
                    return "Kayıt Eklendi";
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public string DelProduct(product delProduct)
        {
            try
            {
                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                    //product product1 = new product();
                    //product1.ProductName = delProduct.ProductName;
                    //product1.Price = delProduct.Price;
                    //product1.Stock = delProduct.Stock;
                    //product1.ImageBase64 = delProduct.ImageBase64;
                    //uow.Repository<product>().Delete(product1);

                    uow.Repository<product>().Delete(delProduct);
                    uow.Save();
                    return "Kayıt silindi.";
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [Authorize]
        public string GetProduct(int ProductId)
        {
            using (var uow = new UnitofWork<search>(new bnetEntities()))
            {
                //    search search = new search();
                //    search.ProductId = search.ProductId;
                uow.Repository<search>().Get(ProductId);
                uow.Save();
                return "hello";
                //get ile aldığım verilerin bilgileini kullancıya döndür
            }
        }
        public string UpdateProduct(product upProduct)
        {
            try
            {
                using (UnitofWork<bnetEntities> unitofWork = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                   // product product1 = new product();
                    //product1.ProductName = upProduct.ProductName;
                   // product1.ProductId = upProduct.ProductId;
                    //product1.Stock = upProduct.Stock;
                    //product1.ImageBase64 = upProduct.ImageBase64;
                    unitofWork.Repository<product>().Update(upProduct);
                    unitofWork.Save();
                    return "kayıt güncelendi";
                }

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}