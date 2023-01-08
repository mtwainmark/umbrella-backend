using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    [Table("user")]
    [Comment("Пользователь")]
    public class User
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Column("id")]
        [Comment("Идентификатор")]
        public long Id { get; set; }
        /// <summary>
        /// Полное имя
        /// </summary>
        [Column("full_name")]
        [Comment("Идентификатор")]
        public string FullName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [Column("email")]
        [Comment("Email")]
        public string Email { get; set; }
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        [Column("image_url")]
        [Comment("Ссылка на изображение")]
        public string? ImageUrl { get; set; }

    }
}
