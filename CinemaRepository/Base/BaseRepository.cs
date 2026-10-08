using CinemaDomain.Base;
using System;
using System.Collections.Generic;
using System.Text;
using CinemaRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace CinemaRepository.Base
{
    public class BaseRepository<TypeEntity> : InterfaceBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDBContext; /*contexto que herda do DbContext do ORM (usado para não escrever
        toda vez o mesmo código de conexão com o banco de dados)*/

        public BaseRepository(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
            _myDBContext.Set<TypeEntity>();
        }

        public void Create(TypeEntity entity)
        {
            _myDBContext.Add(entity);
            _myDBContext.SaveChanges();
        }

        public TypeEntity ReadById(int id)
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList().Find(x => x.Id == id);
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList();
        }

        public void Update(TypeEntity entity)
        {
            _myDBContext.Entry(entity).State = EntityState.Modified;
            _myDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _myDBContext.Remove(ReadbyId(id));
            _myDBContext.SaveChanges();
        }
    }
}
