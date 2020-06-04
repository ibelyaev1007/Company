using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        /// <summary>
        /// Get all service Items
        /// </summary>   
        IQueryable<ServiceItem> GetServiceItems();

        /// <summary>
        /// Get service Item by id
        /// </summary>  
        /// <param name="id">ID</param>
        ServiceItem GetServiceItemById(Guid id);

        /// <summary>
        /// Save service Item
        /// </summary>
        /// <param name="entity">Entity</param>
        void SaveServiceItem(ServiceItem entity);

        /// <summary>
        /// Delete service Item
        /// </summary>
        /// <param name="id">ID</param>        
        void DeleteServiceItem(Guid id);
    }
}
