using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sozluk.EntityLayer.Concrete;

namespace Sozluk.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
    }
}
