using System;
using System.Collections.Generic;
using System.Text;
using CinemaDomain.Base;

namespace CinemaRepository.Base
{
    public interface InterfaceBaseRepository<TypeEntity> where TypeEntity : InterfaceBaseEntity
    {
        // MÉTODOS CRUD
        void Create(TypeEntity entity);
        TypeEntity ReadById(int id);
        IList<TypeEntity> ReadAll();
        void Update(TypeEntity entity);
        void Delete(int id);
    }
}
