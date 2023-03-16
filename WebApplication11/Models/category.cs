using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication11.Models
{
    public class category
    {
        public int CategoryId { get; set; }
        public string CName { get; set; }
        public bool Cstatus { get; set; }
    }
}
