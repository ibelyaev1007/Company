using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        /// <summary>
        /// Get all text fields
        /// </summary>   
        IQueryable<TextField> GetTextFields();

        /// <summary>
        /// Get text field by id
        /// </summary> 
        /// <param name="id">ID</param>
        TextField GetTextFieldById(Guid id);

        /// <summary>
        /// Get text field by code word
        /// </summary>
        /// <param name="codeWord">Code Word</param>
        TextField GetTextFieldByCodeWord(string codeWord);

        /// <summary>
        /// Save text field
        /// </summary>
        /// <param name="entity">Entity</param>
        void SaveTextField(TextField entity);

        /// <summary>
        /// Delete text field
        /// </summary>
        /// <param name="id">ID</param>
        void DeleteTextField(Guid id);
    }
}
