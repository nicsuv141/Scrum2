using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer.Models;

namespace Datalayer.Repositories
{
    class CommentRepository
    {
        //Retrieve all comments for a blog entry
        public List<BlogEntryComment> GetComments(BlogEntry model)
        {
            List<BlogEntryComment> listOfComments = (List<BlogEntryComment>)model.Comments;
            return listOfComments;
        }
    }
}
