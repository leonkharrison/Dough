using Dough.Data;
using Dough.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        public BaseService( DoughDbContext doughDbContext ) 
        {
            _doughDbContext = doughDbContext;
            _dbSet = doughDbContext.Set<TEntity>();
            _isPermanentEntity = typeof( TEntity ).BaseType == typeof( PermanentEntity );
        }

        public async Task DeleteAsync( TEntity entity )
        {
            if( _isPermanentEntity )
            {
                ( entity as PermanentEntity ).IsDeleted = true;
                _dbSet.Update( entity );
            }
            else
            {
                _dbSet.Remove( entity );
            }

            await _doughDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync( IEnumerable<TEntity> entities )
        {
            if( _isPermanentEntity )
            {
                foreach( var entity in entities )
                {
                    ( entity as PermanentEntity ).IsDeleted = true;
                }

                _dbSet.UpdateRange( entities );
            }
            else
            {
                _dbSet.RemoveRange( entities );
            }

            await _doughDbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync( int id )
        {
            return await _dbSet.AnyAsync( x => x.Id == id );
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<TEntity> GetAsync( int id )
        {
            return GetAsync( id, false );
        }

        public async Task<TEntity> GetAsync( int id, bool lazyLoad )
        {
            if( !lazyLoad )
            {
                return await _dbSet.FirstOrDefaultAsync( x => x.Id == id );
            }

            IQueryable<TEntity> query = _dbSet;

            var navigationProperties = typeof( TEntity ).GetProperties().
                Where( p => p.GetGetMethod().IsVirtual && 
                !p.GetGetMethod().IsFinal && 
                typeof( BaseEntity ).IsAssignableFrom( p.PropertyType ) );

            foreach( var property in navigationProperties )
            {
                query = query.Include( property.Name );
            }

            return await query.FirstOrDefaultAsync( x => x.Id == id );
        }

        public async Task<TEntity> InsertAsync( TEntity entity )
        {
            entity.Id = 0;
            entity.CreatedAt = DateTime.UtcNow;
            entity.LastModifiedAt = DateTime.UtcNow;

            var result = _dbSet.Add( entity );
            await _doughDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<TEntity>> InsertAsync( IEnumerable<TEntity> entities )
        {
            entities.ToList().ForEach( x =>
            {
                x.CreatedAt = DateTime.UtcNow;
                x.LastModifiedAt = DateTime.UtcNow;
                x.Id = 0;
            } );

            _dbSet.AddRange( entities );
            await _doughDbContext.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> UpdateAsync( TEntity entity )
        {
            entity.LastModifiedAt = DateTime.UtcNow;

            _dbSet.Update( entity );
            await _doughDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateAsync( IEnumerable<TEntity> entities )
        {
            entities.ToList().ForEach( x => x.LastModifiedAt = DateTime.UtcNow );

            _dbSet.UpdateRange( entities );
            await _doughDbContext.SaveChangesAsync();
            return entities;
        }


        protected readonly DbSet<TEntity> _dbSet;
        protected readonly DoughDbContext _doughDbContext;
        readonly bool _isPermanentEntity;
    }
}
