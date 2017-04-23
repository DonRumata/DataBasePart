using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMVPDataBasePart.IModels
{
    public interface ILoginService
    {
        bool Login(string Username, string Pass, IDataConnection DBOperational);
    }
}
