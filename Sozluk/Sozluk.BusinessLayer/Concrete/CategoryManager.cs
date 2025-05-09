using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sozluk.BusinessLayer.Abstract;
using Sozluk.DataAccessLayer.Abstract;
using Sozluk.DataAccessLayer.Concrate.Repositories;
using Sozluk.EntityLayer.Concrete;

namespace Sozluk.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
