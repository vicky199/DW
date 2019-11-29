using DW.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DW.BAL.IBusiness
{
    interface IUserBusiness
    {
        UserModel GetUserModel();
        void InsertUser(UserModel userModel);
    }
}
