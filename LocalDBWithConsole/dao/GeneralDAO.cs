using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDBWithConsole.model;

namespace LocalDBWithConsole.dao
{
    interface GeneralDAO
    {
        void pushData(UserLocalDB userLocalDb);
        void getData();
        bool delData(string username);
    }
}
