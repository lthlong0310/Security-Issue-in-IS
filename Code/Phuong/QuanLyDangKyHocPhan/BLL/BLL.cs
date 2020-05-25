using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAL;

namespace BLL
{
    public class BLL
    {
        public User Login(User current_user)
        {
            current_user = new DAL.DAL().Login(current_user);
            return current_user;
        }

    }
}
