using Microsoft.EntityFrameworkCore;
using RDHTWC.Domain.Base;
using RDHTWC.Domain.Repositories;
using RDHTWC.Infraestructure.Context;
using RDHTWC.Infraestructure.Operations.Implementacions;
using RDHTWC.Infraestructure.Operations.Interfaces;
using System.Linq.Expressions;

namespace RDHTWC.Persistence.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> _entity { get; }
        protected readonly RDHTWCContext _context;
        protected readonly IBaseOperations _operations;

        public  BaseRepository(RDHTWCContext context) 
        {
            _context = context;
            _entity = _context.Set<TEntity>();
            _operations = new BaseOperations();
        }

        public virtual async Task<OperationResult> GetAllAsync()
        {
            try
            {
                var data = await _entity.ToListAsync();
                return _operations.SuccesOperation(data, "Registros obtenidos con exito."); 
            }
            catch (Exception ex)
            {

                return _operations.HandleException("Error obteniendo los registros.", ex);
            }
            
        }

        public virtual async Task<OperationResult> GetByIdAsync(int id)
        {
            try
            {
                var data = await _entity.FindAsync(id);

                return _operations.SuccesOperation(data, "Registro obtenido con exito.");

            }
            catch (Exception ex)
            {

                return _operations.HandleException("Error obteniendo el registro.", ex);
            }

           
        }
        public virtual async Task<OperationResult> SaveEntityAsync(TEntity entity)
        {
            try
            {
                _entity.Add(entity);
                await _context.SaveChangesAsync();

                return _operations.SuccesOperation(entity, "Se ha guardado el registro correctamente.");
            }
            catch (Exception ex)
            {

                return _operations.HandleException("Error guardando los registrso.", ex);
            }
            
        }

        public virtual async Task<OperationResult> UpdateEntityAsync(TEntity entity)
        {
            try
            {
                
                _entity.Update(entity);
                await _context.SaveChangesAsync();

                return _operations.SuccesOperation(entity, "Se ha actualizado el registro correctamente.");
            }
            catch (Exception ex)
            {
                return _operations.HandleException("Error actualizando el registro.", ex);

            }
            
        }

        public virtual async Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                
                var data = await _entity.Where(filter).ToListAsync();

                return _operations.SuccesOperation(data, "Registros obtenidos exitosamente.");

            }
            catch (Exception ex)
            {

                return _operations.HandleException("Error obteniendo los registros.", ex);
            }
           
        }

    }
}
