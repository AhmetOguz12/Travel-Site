using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public interface  ISeyahatService
    {
        IDataResult<List<Seyahat>> GetAll();
        IResult Add(AddSeyahat Seyahat);
        IResult Delete(Seyahat seyahat);
        IResult Update(UpdateSeyahat seyahat);
    }
}
