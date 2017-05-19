using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.IModels;
using ModelMVPDataBasePart.Common;

namespace ModelMVPDataBasePart.Models
{
    public class MainModel : IMainIModel
    {
        public object GetMainView(IMainFormData DBOperational)
        {
            return DBOperational.GetBaseView();
        }
    }
}
