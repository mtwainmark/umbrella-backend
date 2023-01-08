using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    [Table("post")]
    [Comment("Пост")]
    public class Post
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Column("id")]
        [Comment("Идентификатор")]
        public long Id { get; set; }
        /// <summary>
        /// Заголовок
        /// </summary>
        [Column("title", TypeName = "varchar(200)")]
        [Comment("Заголовок")]
        public string Title { get; set; }
        /// <summary>
        /// Текст
        /// </summary>
        [Column("body", TypeName = "varchar(2000)")]
        [Comment("Текст")]
        public string Body { get; set; }
        /// <summary>
        /// Тэги
        /// </summary>
        [Column("tags")]
        [Comment("Тэги")]
        public IList<Tag> Tags { get; set; }
        /// <summary>
        /// Количество просмотров
        /// </summary>
        [Column("view_count")]
        [Comment("Количество просмотров")]
        public int ViewCount { get; set; } = 0;
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        [Column("image_url", TypeName = "varchar(400)")]
        [Comment("Ссылка на изображение")]
        public string? ImageUrl { get; set; }
        /// <summary>
        /// Автор
        /// </summary>
        [Column("user_id")]
        [Comment("Автор")]
        public long UserId { get; set; }

        public User User { get; set; }

    }
}
