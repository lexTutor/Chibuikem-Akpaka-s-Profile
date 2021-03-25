using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KingdomProfile.ViewModels
{
    public class UserHomeModel
    {
        public UserHomeModel()
        {
            this.Technologies = new Dictionary<string, string>();
            this.Projects = new Dictionary<string, string>();
            this.Refrees = new Dictionary<string, string[]>();
            this.Images = new List<string>();
            this.SocialMediaHandles = new List<string>();
        }
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string UserStory { get; set; }

        public string CoreExpertise { get; set; }

        public Dictionary<string, string> Technologies { get; set; }

        public Dictionary<string, string> Projects { get; set; }

        public string EmailAddress { get; set; }

        public Dictionary<string, string[]> Refrees { get; set; }

        public  List<string> Images { get; set; }

        public List<string> SocialMediaHandles { get; set; }

    }
}
