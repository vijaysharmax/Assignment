using System.ComponentModel.DataAnnotations;

namespace UserRegistration.API.Models.RequestModels
{
    public class UserRequestModel
    {
       
     
        public string Name { get; set; }

      
        public string Gender { get; set; }

    
        public DateTime DateOfBirth { get; set; }

  
        public string Email { get; set; }

        
        public string ContactNo { get; set; }

       
        public int StateId { get; set; }

     
        public int CityId { get; set; }

        public string Hobbies { get; set; }

        public string PhotoPath { get; set; }

     
        public bool IsTermsAccepted { get; set; }
    }
}

