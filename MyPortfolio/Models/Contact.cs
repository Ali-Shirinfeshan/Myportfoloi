using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Contact
    {
        //اطلاعات دریافتتی توسط فرم تماس با ما
        [Required(ErrorMessage ="این فیلد الزامی می باشد")]
        [MaxLength(50,ErrorMessage ="حداکثر مقدار این فیلد 3 کاراکتر می باشد")]
        [MinLength(3, ErrorMessage = "حداقل مقدار این فیلد 3 کاراکتر می باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد الزامی می باشد")]
        [EmailAddress(ErrorMessage ="آدرس ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }
        [Required(ErrorMessage = "این فیلد الزامی می باشد")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "این فیلد الزامی می باشد")]
        public string Message { get; set; }

        //اطلاعات نمایش در قالب بخش تماس با ما
        public string Address { get; set; }
        public string MyEmail { get; set; }
        public string Mobile { get; set; }


    }
}
