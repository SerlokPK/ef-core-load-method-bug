using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repositories.Extensions
{
    /// <summary>
    /// The queryable extensions.
    /// </summary>
    public static class QueryableExtensions
    {
        /// <summary>
        /// Allows to load multiple properties to DB entity.
        /// </summary>
        /// <typeparam name="T">The type of a DB entity</typeparam>
        /// <param name="query">The query on which this method will be called.</param>
        /// <param name="includeProperties">The properties that will be loaded.</param>
        public static void LoadMultipleProperties<T>(this IQueryable<T> query, params string[] includeProperties)
            where T : class
        {
            foreach (var prop in includeProperties)
            {
                query.Include(prop).Load();
            }
        }
    }
}
