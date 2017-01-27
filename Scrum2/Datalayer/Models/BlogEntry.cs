using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Datalayer.Models
{
    public class BlogEntry
    {
        public int BlogEntryId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public bool IsFormal { get; set; }

        public virtual User Author { get; set; }
        public virtual File Attachment { get; set; }
        public virtual ICollection<BlogEntryComment> Comments { get; set; }
    }
}
