using System.ComponentModel.DataAnnotations;

namespace Sozluk.EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Value { get; set; }
        public DateTime Date { get; set; }

        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
