using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddresss
{
    class DataProcessing
    {



        List<UserData> listOfUsersData = new List<UserData>();
        public void InsertUserData(UserData userData)
        {
            listOfUsersData.Add(userData);
        }
        public List<UserData> DisplayUserData()
        {
            return listOfUsersData;
        }
    }
}
