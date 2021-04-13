using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    class Practice
    {
    }

    public class Post
    {
        [Key]
        public int int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
        public Guid AuthorId { get; set; }

    }

    public class Comment

        [Key]

        public int Id { get; set; }
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
        public virtual List<Reply> Replies { get; set; }
        [ForeignKey] to Post via Id w/ virtual Post) 
 
 
 

}
