using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public int Id { get; set; }
        private string _key;

        public string key
        {
            get
            {
                if(_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^A-Z0-9]", "-");
                }
                return _key;
              
            }
            set { _key = value; }
        }

        [Required ]
        [Display(Name ="Post Title")]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Title must be between 5-100 characters long")]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        public string Author { get; set; }

        [Required]
        [MinLength(100,  ErrorMessage = "Body must be  at least 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public DateTime Posted { get; set; }
        
    }
}
