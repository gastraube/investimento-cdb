using System.ComponentModel.DataAnnotations;

namespace B3.Web.DTOs
{
    public class ContatoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email{ get; set; }
    }
}