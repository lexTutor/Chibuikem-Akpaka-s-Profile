using System;
using System.Collections.Generic;
using System.Linq;
using KingdomProfile.ViewModels;
using KingdomProfile.Models;

namespace KingdomProfile.LocalORM
{
    public class MapperTool
    {
        public static UserHomeModel ModelMapper(UserProfileDetails userToMap)
        {
            var _technologies = new Dictionary<string, string>();
            var _projects = new Dictionary<string, string>();
            var _refrees = new Dictionary<string, string[]>();
            var _images = new List<string>();

            string expertise = string.Empty;
            foreach (var item in userToMap.Technologies)
            {
                _technologies.Add(item.Skill, item.Rating.ToString());
            }
            foreach (var item in userToMap.Projects)
            {
                _projects.Add(item.ProjectTitle, item.LinkToGitHub);
            }
            foreach (var item in userToMap.Refrees)
            {
                var array = new string[] { item.RefreeName, item.RefreeDetails, item.RefreeComments };
               _refrees.Add(item.RefreePicture, array);
            }
            foreach (var item in userToMap.Images)
            {
                _images.Add(item.ImageUrl);
            }
           

            UserHomeModel HomeUser = new UserHomeModel
            {
                FullName = string.Join(" ", userToMap.FirstName, userToMap.LastName),
                PhoneNumber = string.Join(" ", userToMap.phoneNumbers[0].CountrCode, userToMap.phoneNumbers[0].PhoneNumber),
                Technologies = _technologies,
                Address = string.Join(",", userToMap.MyAddress.City, userToMap.MyAddress.Country),
                UserStory = userToMap.UserStory,
                CoreExpertise = string.Join(", ", userToMap.AreasOfExpertise),
                EmailAddress = userToMap.EmailAddress,
                Projects = _projects,
                Refrees = _refrees,
                Images = _images,
                SocialMediaHandles = new List<string> { userToMap.Handles.LinkedIn, userToMap.Handles.Twitter, userToMap.Handles.Facebook }
                
            };

            return HomeUser;
        }
    }
}
