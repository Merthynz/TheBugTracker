using System.ComponentModel;

#nullable disable

namespace TheBugTracker.Models
{
    public class ProjectPriority
    {
        //Primary Key
        public int Id { get; set; }

        [DisplayName("Priority Name")]
        public string Name { get; set; }
    }
}
