﻿using Core.Entities.Concrete;
using Core.Utilites.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUser(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetByEmail(string email);
        IResult ChangeUserInfo(ChangeUserInfoDto userInfo);
        IResult ChangeUserPassword(ChangeUserPasswordDto userInfo);
    }
}
