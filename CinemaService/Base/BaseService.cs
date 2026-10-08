using AutoMapper;
using CinemaDomain.Base;
using CinemaRepository.Base;
using FluentValidation;
using Microsoft.IdentityModel.Tokens.Experimental;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Base
{
    public class BaseService<TypeEntity> : InterfaceBaseService<TypeEntity> where TypeEntity : InterfaceBaseEntity
    {
        private readonly InterfaceBaseRepository<TypeEntity> _baserepository;
        private readonly IMapper _mapper;
        public BaseService(InterfaceBaseRepository<TypeEntity> baserepository, IMapper mapper)
        {
            _baserepository = baserepository;
            _mapper = mapper;
        }

        public void Validate(TypeEntity obj, AbstractValidator<TypeEntity> validator)
        {
            validator.ValidateAndThrow(obj);
        }
        public TypeOutputModel Create<TypeInputModel, TypeOutputModel, TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>
        {
            var e = _mapper.Map<TypeEntity>(entity);
            Validate(e, Activator.CreateInstance<TypeValidator>());
            _baserepository.Create(e);
            return _mapper.Map<TypeOutputModel>(e);
        }

        public void Create(TypeEntity entity)
        {
            throw new NotImplementedException();
        }

        public TypeEntity ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeOutputModel> ReadAll<TypeOutputModel>() where TypeOutputModel : class
        {
            throw new NotImplementedException();
        }

        public IList<TypeEntity> ReadAll()
        {
            throw new NotImplementedException();
        }

        public TypeOutputModel ReadById<TypeOutputModel>(int id) where TypeOutputModel : class
        {
            throw new NotImplementedException();
        }

        public TypeOutputModel Update<TypeInputModel, TypeOutputModel, TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>
        {
            throw new NotImplementedException();
        }

        public void Update(TypeEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
