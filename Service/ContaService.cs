using BancoEveris.Model;
using BancoEveris.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoEveris.Service
{
    public class ContaService
    {
        private ContaRepository _repository = new ContaRepository();

        public List<Conta> Lista()
        {
            return _repository.Lista();
        }
    }
}
