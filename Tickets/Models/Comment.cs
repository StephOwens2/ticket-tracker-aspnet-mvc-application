using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets.Models
{
    public class Comment
    {

        [Key]
        public int CommentId { get; set; }
        public DateTime CommentDate { get; set; }
+
        //Relationship
        public int TicketId { get; set; }
        [ForeignKey("TicketId")]
        public Ticket Tickets { get; set; }


    }
}
