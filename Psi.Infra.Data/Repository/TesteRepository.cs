using Psi.Domain.Entities;
using Psi.Domain.Interfaces;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Psi.Infra.Data.Repository
{
    public class TesteRepository : BaseRepository<Teste, int>, ITesteRepository
    {
        public TesteRepository(AppDBContext mySqlContext) : base(mySqlContext)
        {
        }

        public void Remove(int id) =>
            base.Delete(id);


        public void Save(Teste obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj);
        }

        public Teste GetById(int id) =>
            base.Select(id);

        public IList<Teste> GetAll() =>
            base.Select();

    }
}
