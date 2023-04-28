using System.ComponentModel.DataAnnotations;

namespace MertProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet icon linki giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100,ErrorMessage ="Hizmet Başlığı en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
