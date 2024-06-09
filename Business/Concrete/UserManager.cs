﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.DataAccess;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        Context _context;
        private readonly UserManager<IdentityUser> _userManager;
        public UserManager(Context context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IDataResult<IdentityUser>> Login(string password, string username)
        {
            IdentityUser user = null;

            if (!string.IsNullOrEmpty(username))
            {
                user = await _userManager.FindByNameAsync(username);
            }
            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                return new SuccessDataResult<IdentityUser>(user, "Giriş Başarılı");
            }
            return new ErrorDataResult<IdentityUser>(null, "Kullanıcı Adı veya Parola Hatalı");
        }

        public async Task<IResult> SignUp(IdentityUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded
                ? new SuccessResult("Kayıt Başarıyla Oluşturuldu")
                : new ErrorResult(string.Join(",", "Kullanıcı Adı OLuşturmada Hata Var"));
        }
    }
}
