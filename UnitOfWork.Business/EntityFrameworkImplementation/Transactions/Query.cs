using System;
using UnitOfWork.Data.Database;

namespace UnitOfWork.Business.EntityFrameworkImplementation.Transactions
{
    internal class Query
    {
        internal Properties CreateUpdate(Properties model)
        {
            try
            {
                using (var context = new UnitOfWorkDevelopmentEntities())
                {
                    Properties property;
                    if (model?.Id == 0)
                    {
                        property = context.Properties.Add(model);
                    }
                    else{
                        property = context.Properties.Find(model?.Id);
                        property.DateCreated = DateTime.UtcNow;
                        property.Sequence = model.Sequence;
                        property.Nickname = model.Nickname;
                        context.Entry(property).State = System.Data.Entity.EntityState.Modified;
                        
                    }
                    context.SaveChanges();
                    return property;
                }
            }
            catch (Exception )
            {
                return null;
            }
        }
    }
}
