using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranzLibrary
{
    public interface IStorage
    {

        public string Load(string _input, string end);
    }
}
