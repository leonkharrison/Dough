﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Services
{
    public interface IBaseService<T>
    {
        Task<bool> ExistsAsync( int id );
        
        Task<T> GetAsync( int id );
        Task<T> GetAsync( int id, bool lazyLoad );
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> InsertAsync( T entity );
        Task<IEnumerable<T>> InsertAsync( IEnumerable<T> entities );

        Task<T> UpdateAsync( T entity );
        Task<IEnumerable<T>> UpdateAsync( IEnumerable<T> entities );

        Task DeleteAsync( T entity );
        Task DeleteAsync( IEnumerable<T> entities );
    }
}
