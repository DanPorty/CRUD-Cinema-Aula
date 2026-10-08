using CinemaDomain.Base;
using CinemaRepository.Base;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Base
{
    public interface InterfaceBaseService<TypeEntity> : InterfaceBaseRepository<TypeEntity> where TypeEntity : InterfaceBaseEntity
    {
        //Assinatura de um metodo, que retorna um tipo de classe generico
        //Apos criar no banco retorna exatamente a classe que criou
        //Precisa do objeto de entrada (deve ser do meu dominio), saida (formatar do jeito que eu quiser na minha tela) e o validator
        TypeOutputModel Create<TypeInputModel,
                               TypeOutputModel,
                               TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>;
        //o where define que tipo de objeto posso usar no generico

        TypeOutputModel ReadById<TypeOutputModel>(int id) where TypeOutputModel : class;

        IEnumerable<TypeOutputModel> ReadAll<TypeOutputModel>() where TypeOutputModel : class;

        TypeOutputModel Update<TypeInputModel,
                               TypeOutputModel,
                               TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>;

        void Delete(int id);
    }
}
