using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Ticket
    {
        
        [Key]
        public int TicketId { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Data.TicketStatus Status { get; set; }    

        // Relationships
        public List<Comment> Comments { get; set; }

    }
}
