using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "lütfen oda numarası giriniz.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "lütfen oda görseli ekleyiniz.")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "lütfen oda başlığı bilgisi giriniz.")]
        [StringLength(100,ErrorMessage ="lütfen 100 karakter olucak şekilde başlık giriniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "lütfen yatak sayısı giriniz.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "lütfen banyo sayısı giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "lütfen açıklama yazınız.")]
        public string Description { get; set; }
    }
}
