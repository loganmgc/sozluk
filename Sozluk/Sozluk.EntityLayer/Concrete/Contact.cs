using System.ComponentModel.DataAnnotations;

namespace Sozluk.EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
