using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPBlog.Models
{
    public class Blog
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublisedDate { get; set; }
        public string Category { get; set; }
        public int Hits { get; set; }

        [Display(Name = "Description")]
        public string DescriptionTrimmed
        {
            get
            {
                try
                {
                    if (this.Description.Length > 20)
                        return this.Description.Substring(0, 20) + "...";
                    else
                        return this.Description;
                }
                catch (NullReferenceException)
                {
                    this.Description = "";
                    return this.Description;
                    
                    // throw;
                }
                
            }
        }
    }
    public enum Category
    {
        Travel,
        Business,
        Entertainment
    }
}
