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
    public interface IŞehirService
    {
        IDataResult<List<Şehir>> GetAll();
        IResult Add(AddŞehir şehir);
        IResult Delete(Şehir şehir);
        IResult Update(UpdateŞehir şehir);
    }
}
