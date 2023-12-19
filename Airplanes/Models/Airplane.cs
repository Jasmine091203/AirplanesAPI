using System.ComponentModel.DataAnnotations;
namespace Airplanes.Models
{
    public class Airplane
    {
        [Key] public Guid Pid { get; set; }
        [Required] public String Pname { get; set; }
        [Required] public int Pseats { get; set; }
        [Required] public int Pmaxspeed { get; set; }
        public float Pheavyload { get; set; }
    }
}