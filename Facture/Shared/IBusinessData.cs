using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facture.Shared
{
    public interface IBusinessData
    {
        public IEnumerable<string> Factures { get; }
    }
}
