using System.ComponentModel.DataAnnotations;

namespace ViewsDemo.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        
        //[Custom("some error message","optional param",MinValue =1,MaxValue =10)]
        [Required(AllowEmptyStrings =false, ErrorMessage = "DisplayName is required")]
        [StringLength(20, ErrorMessage = "url must be between 10 and 20 characters", MinimumLength = 10)]
        public string DisplayName { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [StringLength(20,ErrorMessage ="url must be between 10 and 20 characters",MinimumLength =10)]
        public string Url { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string PhotographerEmail{ get; set; }
    }
}