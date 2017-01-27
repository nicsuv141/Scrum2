using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Models
{
    public class BlogEntry
    {
        public int BlogEntryId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User Author { get; set; }
        public virtual File Attachment { get; set; }
        public virtual HashSet<BlogEntryComment> Comments { get; set; }
    }
}
