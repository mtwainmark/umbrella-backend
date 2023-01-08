using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    [Table("tag")]
    [Comment("Тэг")]
    public class Tag
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Column("id")]
        [Comment("Идентификатор")]
        public long Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [Column("title")]
        [Comment("Наименование")]
        public string Name { get; set; }
        /// <summary>
        /// Пост
        /// </summary>
        [Column("post_id")]
        [Comment("Пост")]
        public long PostId { get; set; }

        public Post Post { get; set; }
    }
}
