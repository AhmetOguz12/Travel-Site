using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ISeyahatDal _seyahatDal;

        public RentalManager(IRentalDal rentalDal, ISeyahatDal seyahatDal)
        {
            _rentalDal = rentalDal;
            _seyahatDal = seyahatDal;
        }

        public IResult Add(AddRental rental)
        {
            // Kiralama kontrolü
            var checkResult = CheckRentalSeyahatId(rental.SeyahatId, 1); // 1 kişilik kiralama kontrolü

            if (!checkResult.Success)
            {
                return checkResult;
            }
            // Yeni kiralama oluşturma
            var newRental = new Rental()
            {
                SeyahatId = rental.SeyahatId,
                UserId = rental.UserId
            };
            _rentalDal.Add(newRental);
            return new SuccessResult("Kiralama Başarılı");
        }

        public IDataResult<Rental> CheckRentalSeyahatId(int seyahatId, int kişiSayısı)
        {
            var toplamKişiSayısı = _rentalDal.GetAll(r => r.SeyahatId == seyahatId).Count();
            var seyahat = _seyahatDal.Get(s => s.Id == seyahatId);

            if (seyahat == null)
            {
                return new ErrorDataResult<Rental>("Seyahat bulunamadı");
            }

            if (toplamKişiSayısı + kişiSayısı > seyahat.KişiSayısı)
            {
                return new ErrorDataResult<Rental>("Seyahat Dolu");
            }
            return new SuccessDataResult<Rental>("Kiralama Başarılı");
        }


        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Kiralama Silindi");
        }

        public IDataResult<List<Rental>> GetAll()
        {

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "Kiralamalar Listelendi");
        }

        public IResult Update(UpdateRental updateRental)
        {
            var updaterental = new Rental()
            {
                Id = updateRental.Id,
                SeyahatId = updateRental.SeyahatId,
                UserId = updateRental.UserId
            };
            _rentalDal.Update(updaterental);
            return new SuccessResult("Kiralama Güncellendi");
        }
    }
}
