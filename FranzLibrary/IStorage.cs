using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranzLibrary
{
    /// <summary>
    /// Interface zum implementieren von Load() 
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Methode die Implementiert werden muss.
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        abstract string Load(string _input, string end);
    }
}
