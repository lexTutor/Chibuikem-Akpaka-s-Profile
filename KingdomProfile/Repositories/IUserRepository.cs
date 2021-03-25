using KingdomProfile.ViewModels;

namespace KingdomProfile.Models
{
    public interface IUserRepository
    {
        UserHomeModel GetUserProfile(int Id);
    }
}