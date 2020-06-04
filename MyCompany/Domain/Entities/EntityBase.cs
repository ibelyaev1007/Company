using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Constructor set default DateAdded
        /// </summary>
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [Display(Name = "Название (заголовок)")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Subtitle
        /// </summary>
        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Title Image Path
        /// </summary>
        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        /// <summary>
        /// Meta Title
        /// </summary>
        [Display(Name = "SEO метатег Title")]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Meta Description
        /// </summary>
        [Display(Name = "SEO метатег Description")]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Meta Keywords
        /// </summary>
        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
