using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        /// <summary>
        /// Field Code Word
        /// </summary>        
        [Required]
        public string CodeWord { get; set; }

        /// <inheritdoc/>
        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";

        /// <inheritdoc/>
        [Display(Name = "Cодержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
