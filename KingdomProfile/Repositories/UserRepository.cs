using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KingdomProfile.LocalORM;
using KingdomProfile.ViewModels;

namespace KingdomProfile.Models
{
    public class UserRepository : IUserRepository
    {
        private void AddUser()
        {
            UserProfileDetails user = new UserProfileDetails
            {
                FirstName = "Chibuikem",
                LastName = "Akpaka",
                Id = 1,
                phoneNumbers = new List<PhoneNumbers>
                {
                    new PhoneNumbers { CountrCode = "+234", PhoneNumber = "8166807840" }
                },

                MyAddress = new Address { Street = "Eweje", City = "Lagos", StateOfResidence = "Lagos", StateOfOrigin = "Abia", ZipCode = 100212, Country = "Nigeria" },

                Technologies = new List<Technologies>
                {
                    new Technologies { Skill = "C#", Rating = 85 },
                    new Technologies { Skill = ".Net Framework", Rating = 80 },
                    new Technologies { Skill = "Web Design [HTML, CSS, JAVASCRIPT, W3.CSS]", Rating = 75 },
                    new Technologies { Skill = "Writing and Research", Rating = 85 }
                },

                UserStory = "I am a self motivated, creative and inovative thinker whith vast engineering knowledge from my first degree in Mechanical Engineering aand my current field " +
                "of software engineering. I am always enthusiastic about new challenges and I love working in a fast paced environment with the thrills of meeting set goals " +
                "I have interests in Robotics and Artificial Intelligence and  I enjoy travelling.",

                AreasOfExpertise = new List<string> { "Software Engineer", "Mechanical Engineer", "Writer", " Poet." },

                EmailAddress = "Chibuikemakpakar@gmail.com",

                Projects = new List<Projects>
                {
                    new Projects
                    {
                        ProjectTitle = " BLOGIT Web application with ASP.Net MVC",
                        LinkToGitHub = "https://github.com/lexTutor/BLOGITWebApp"
                    },
                    new Projects
                    {
                        ProjectTitle = "Simple calculator using C#, Win forms",
                        LinkToGitHub = "https://github.com/lexTutor/Simple-Calculator"
                    },
                    new Projects
                    {
                        ProjectTitle = "Mobile banking App using C#, Console",
                        LinkToGitHub = "https://github.com/lexTutor/MobileBank-App"
                    },
                    new Projects
                    {
                        ProjectTitle = "Todo Web Application using HTML5, CSS3, Vanilla JavaScript",
                        LinkToGitHub = "https://github.com/lexTutor/Todo-App"
                    },
                   
                },

                Refrees = new List<Refree>
                {
                    new Refree
                    {
                        RefreePicture = "images/rachael.jpg", RefreeName = "Anieweke Rachael.",
                        RefreeDetails = "Telecomunication Analyst with MTN Nigeria",
                        RefreeComments = "Chibuikem Akpaka is a very creative and innovative person. I always enjoy working with him."
                    },

                    new Refree
                    {
                        RefreePicture = "images/kufre.jfif", RefreeName = "Kufreabasi Ita.",
                        RefreeDetails = "Software Engineer at Decagon Institute.",
                        RefreeComments = "Chibuikem Akpaka is an excellent software engineer, with high critical thinking skills."
                    },

                    new Refree
                    {
                        RefreePicture = "images/nekede.jfif",
                        RefreeName = "Engr P.Gray Akinyemi.",
                        RefreeDetails = "Mecahnical Engineering Lecturer at Federal Polytechnic Nekede.",
                        RefreeComments = "Chibuikem Akpaka is a very good student, always eager to learn new things."
                    },
                },
                Images = new List<Images>
                {
                    new Images
                    {
                        ImageUrl = "../images/Cropped_Me (2).jpg"
                    },
                    new Images
                    {
                        ImageUrl = "../images/MicrosoftTeams-image.png"
                    },
                    new Images
                    {
                        ImageUrl = "images/Screenshot (90).png"
                    },
                    new Images
                    {
                        ImageUrl = "images/Screenshot (89).png"
                    },
                    new Images
                    {
                        ImageUrl = "images/mbapp_refined.png"
                    }
                },
                 Handles = new SocialMedia
                 {
                     LinkedIn = "https://www.linkedin.com/in/chibuikem-akpaka-2450171a5/",
                     Twitter = "https://twitter.com/Rowlexblaze16",
                     Facebook = "https://twitter.com/Chibuikem_Akpaka_Rowland"
                 }

            };

            DataContext.DB.Add(user);
        }
        public UserHomeModel GetUserProfile(int Id)
        {
            AddUser();
            var user = DataContext.DB.FirstOrDefault(x => x.Id == Id);
           return MapperTool.ModelMapper(user);
        }

       
    }
}
