using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Interfaces
{
    public interface IScoppedServises
    {
        string GetGuid();
    }
    public class ScoppedServises : IScoppedServises
    {
        private Guid _guid;

        public ScoppedServises()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
