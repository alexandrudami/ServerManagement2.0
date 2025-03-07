using System.ComponentModel.DataAnnotations;    //can have many different attributes that can be found here https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-9.0

namespace BlazorSVM.Models
{
    public class Server
    {
        public Server() 
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber ==0? false : true;

        }

        public int ServerID { get; set; }
        public bool IsOnline { get; set; }
        [Required]  // Required attribute to make sure the Name and City are not null
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
    }
}
