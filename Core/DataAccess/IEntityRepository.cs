
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Bütün entitylerin dallarının içerisine CRUD işlemlerini tekrarlamamak için
    //Generic bir yapı oluşturduk. Generic yapının içerisine bir kere soyutlanmış bir şekilde 
    //CRUD işlemlerimizi yazdık. Generic yapılara <T> değişkeni verilir. Bütün entitiyleri kapsar.
    //Generic constraint
    //Class: referans tip
    //IEntity : IEntity olabilir veya imlepent edebilen bir nesne olabilir.
    //new() : new'lenebilir olmalı. 

    //Özet : where T:class,entity,new() => bunu yazmamızın sebebi biz generic yapıda Entityleri kullanmak istiyoruz. Fakat bu yapıyı eklemezsek 
    //İstediğimiz nesneyi çağırabiliriz. Bunun önüne geçmek için Class yapısında, IEntity ve implement eden bir nesne olabilir dedik. Böylelikle sadece Entity'lerin kullanabilir olmasını sağladık.
    //Sonrasında new() dememizin sebebi ise new() yapmadığımız zaman sadece entity classları için kullabilir oluyordu fakat IEntity'nin kendiside bunu kullanabiliyordu. Bunun önüne geçmek için New yapısını ekledik.
    //Çünkü Interface'ler new'lenemez.
    public interface IEntityRepository<T> where T:class, IEntity,new()
    { 
        //Filtreleme işlemi yapmak için kullanılır.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
