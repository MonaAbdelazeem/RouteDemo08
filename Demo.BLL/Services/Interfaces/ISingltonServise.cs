using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Interfaces
{
    public interface ISingltonServise
    {
        string GetGuid();
    }
    public class SingltonServise : ISingltonServise
    {
        private Guid _guid;

        public SingltonServise()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
