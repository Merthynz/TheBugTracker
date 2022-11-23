using System.ComponentModel;

#nullable disable

namespace TheBugTracker.Models
{
    public class TicketComment
    {
        //Id
        public int Id { get; set; }

        //Comment
        [DisplayName("Member Comment")]
        public string Comment { get; set; }

        //Created
        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }

        //TicketId
        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        //UserId
        [DisplayName("Team Memmber")]
        public string UserId { get; set; }



        // -- Navigation Properties --
        //Ticket
        public virtual Ticket Ticket { get; set; }

        //User
        public virtual BTUser User { get; set; }
    }
}
