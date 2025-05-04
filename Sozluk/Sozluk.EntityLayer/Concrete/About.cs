using System.ComponentModel.DataAnnotations;

namespace Sozluk.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Details1 { get; set; }
        [StringLength(1000)]
        public string Details2 { get; set; }
        [StringLength(100)]
        public string Image1 { get; set; }
        [StringLength(100)]
        public string Image2 { get; set; }
    }
}
