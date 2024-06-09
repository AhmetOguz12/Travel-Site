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
    public class ŞehirManager : IŞehirService
    {
        IŞehirDal _şehirDal;
        public ŞehirManager(IŞehirDal şehirDal)
        {
            _şehirDal = şehirDal;
        }

        public IResult Add(AddŞehir şehir)
        {
            var newŞehir = new Şehir()
            {
                ŞehirAdı = şehir.ŞehirAdı,
           
            };
            _şehirDal.Add(newŞehir);
            return new SuccessResult("Şehir Eklendi");
        }

        public IResult Delete(Şehir şehir)
        {
            _şehirDal.Delete(şehir);
            return new SuccessResult("Şehir Silindi");
        }

        public IDataResult<List<Şehir>> GetAll()
        {
            return new SuccessDataResult<List<Şehir>>(_şehirDal.GetAll(), "Şehirler Listelendi");
        }

        public IResult Update(UpdateŞehir şehir)
        {
            var updateŞehir = new Şehir()
            {
                Id = şehir.Id,
                ŞehirAdı = şehir.ŞehirAdı,
                
            };
            _şehirDal.Update(updateŞehir);
            return new SuccessResult("Şehir Güncellendi");
        }
    }
}
