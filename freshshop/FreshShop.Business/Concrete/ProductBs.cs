using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Concrete;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Concrete
{
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository _repo;
        public ProductBs(IProductRepository repo)
        {

            _repo = repo;
        }


        public void Delete(Product entity)
        {
            //loglama , cachleme, validation
            _repo.Delete(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _repo.GetAll(filter);
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
           return _repo.GetByCategoryId(categoryId);
        }

        public Product GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _repo.GetByPriceRange(minPrice, maxPrice);
        }

        public int Insert(Product entity)
        {
            //loglama , cachleme, validation
            return _repo.Insert(entity);
        }

        public void Update(Product entity)
        {
             _repo.Update(entity);
        }
    }
}
