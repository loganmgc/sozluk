using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sozluk.DataAccessLayer.Abstract;
using Sozluk.DataAccessLayer.Concrate;
using Sozluk.DataAccessLayer.Concrate.Repositories;
using Sozluk.EntityLayer.Concrete;

namespace Sozluk.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
