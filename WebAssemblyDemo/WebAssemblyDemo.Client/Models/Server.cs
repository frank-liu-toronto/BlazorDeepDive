using System.ComponentModel.DataAnnotations;

namespace WebAssemblyDemo.Client.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0? false : true;
        }

        public int ServerId { get; set; }
        public bool IsOnline { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }
    }
}
