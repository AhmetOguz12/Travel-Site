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
    public class SeyahatManager : ISeyahatService
    {
        ISeyahatDal _seyahatDal;

        public SeyahatManager(ISeyahatDal seyahatDal)
        {
            _seyahatDal = seyahatDal;
        }

        public IResult Add(AddSeyahat Seyahat)
        {
            var newSeyahat = new Seyahat()
            {
                Açıklama = Seyahat.Açıklama,
                Başlık = Seyahat.Başlık,
                Fiyat = Seyahat.Fiyat,
                GünSayısı = Seyahat.GünSayısı,
                Tarih = Seyahat.Tarih,
                ŞehirId = Seyahat.ŞehirId,
                ImgUrl = Seyahat.ImgUrl,
            };
            _seyahatDal.Add(newSeyahat);
            return new SuccessResult("Seyahat Eklendi");
        }

        public IResult Delete(Seyahat seyahat)
        {
            _seyahatDal.Delete(seyahat);
            return new SuccessResult("Seyahat Silindi");
        }

        public IDataResult<List<Seyahat>> GetAll()
        {
            return new SuccessDataResult<List<Seyahat>>(_seyahatDal.GetAll(),"Seyahatler Listelendi");
        }

        public IResult Update(UpdateSeyahat seyahat)
        {
            var newSeyahat = new Seyahat()
            {
                Id = seyahat.Id,
                Açıklama = seyahat.Açıklama,
                Başlık = seyahat.Başlık,
                Fiyat = seyahat.Fiyat,
                GünSayısı = seyahat.GünSayısı,
                Tarih = seyahat.Tarih,
                ŞehirId = seyahat.ŞehirId,
                ImgUrl = seyahat.ImgUrl,
            };
            _seyahatDal.Update(newSeyahat);
            return new SuccessResult("Seyahat Güncellendi");
        }
    }
}
