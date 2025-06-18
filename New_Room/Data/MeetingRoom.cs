using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomManagementMVCApp.Data
{
    public class MeetingRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RoomId { get; set; }
        [Required]
        [StringLength(50)]
        public string RoomName { get; set; }
        [Required]
        public int Capacity {  get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
