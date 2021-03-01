using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        

    }
}

//Code refactoring yaptım. 
//Core katmanı oluşturup evrensel class'ları burada topladım 