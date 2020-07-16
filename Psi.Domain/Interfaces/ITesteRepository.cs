using Psi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Domain.Interfaces
{
    public interface ITesteRepository
    {
        void Save(Teste obj);

        void Remove(int id);

        Teste GetById(int id);

        IList<Teste> GetAll();
    }
}
