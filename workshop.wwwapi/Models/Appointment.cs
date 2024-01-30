using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    [Table("appointments")]
    public class Appointment
    {
        
        public DateTime Booking { get; set; }
        
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

    }
}
