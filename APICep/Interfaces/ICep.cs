using APICep.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICep.Interfaces
{
    internal interface ICep
    {
        [Get("/ws/{cep}/json")]
        Task<CepModels> GetAddressAsync(string cep);
    }
}
