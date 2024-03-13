using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Feature2
    {
        [Key]
        public int Feature2ID { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}