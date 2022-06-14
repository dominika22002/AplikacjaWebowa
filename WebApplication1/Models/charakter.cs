using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class charakter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Released { get; set; }
        public int RunningTime { get; set; }
        public int Budget { get; set; }
    }
    
}
