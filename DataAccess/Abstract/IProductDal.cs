using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //CRUD işlemlerini bütün Entitylere tekrarlamamak için IEntityRepository Generic yapısını oluşturduk. Bu yapının içerisine
        //CRUD işlemlerini yaptık. Generic yapıların <T> ile gösterildiğini belirtmiştik. Daha sonrasında Entity Dallarımızın içerisine
        //IEntityRepository'i implement ettik. T değişkeni yerine ise hangi EntityDal'a implement ettiysek içerisine onun ismini verdik.
        //Örn: IEntityRepository<Product> gibi. Böylelikle soyutlama işlemini gerçekleştirmiş olduk.

        List<ProductDetailDto> GetProductDetails();
    }
}
