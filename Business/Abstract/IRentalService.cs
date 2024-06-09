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
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IResult Add(AddRental rental);
        IResult Delete(Rental rental);
        IResult Update(UpdateRental updateRental);
        IDataResult<Rental> CheckRentalSeyahatId(int seyahatId, int kişiSayısı);
    }
}
