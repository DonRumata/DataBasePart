using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.IModels;
using ModelMVPDataBasePart.Common;

namespace ModelMVPDataBasePart.Models
{
    public class LoginModel:ILoginService
    {
        public bool Login(string Username, string Pass, IDataConnection DBOperational)
        {
            return (DBOperational.CreateConnection(Username, Pass, 2));
        }
    }
}
