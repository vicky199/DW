using System;
using System.Collections.Generic;
using System.Text;

namespace DW.Model.Models
{
    public class UserModel
    {
        #region private

        private string name;

        private string lastName;

        #endregion

        #region public

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion
    }
}
