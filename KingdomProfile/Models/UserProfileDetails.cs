using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomProfile.Models
{
    public class UserProfileDetails
    {
        public UserProfileDetails()
        {
          this.Technologies = new List<Technologies>();
          this.Projects = new List<Projects>();
            this.Images = new List<Images>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address MyAddress { get; set; }

        public List<Technologies> Technologies { get; set; }

        public List<string> AreasOfExpertise { get; set; }

        public List<PhoneNumbers>  phoneNumbers{ get; set; }
        public string UserStory { get; set; }
        public string EmailAddress { get; set; }

        public List<Projects> Projects { get; set; }

        public List<Refree> Refrees { get; set; }

        public List<Images> Images { get; set; }

        public SocialMedia Handles { get; set; }

    }
}
