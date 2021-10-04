using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class Client
    {
        [Key]
        public int clientID {  get; set; }
        [Required]
        //[DataType("nvarchar(100)") ]
        public string clientName {  get; set; }
        [Required]
        //[DataType("nvarchar(150)")]
        public string clientAddress {  get; set; }
        [Required]
        //[DataType("nvarchar(100)")]
        public string clientCity {  get; set; }
        [Required]
        //[DataType("nvarchar(100)")]
        public string clientState {  get; set; }
        [Required]
        //[DataType("nvarchar(10)")]
        public string clientPostCode {  get; set; }
        [Required]
        //[DataType("nvarchar(100)")]
        public string clientCountry {  get; set; }

    }
}
