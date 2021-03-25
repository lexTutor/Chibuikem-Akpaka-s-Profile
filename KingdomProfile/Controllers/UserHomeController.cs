using KingdomProfile.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomProfile.Controllers
{
    public class UserHomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserHomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult UserHome()
        {
            return View(_userRepository.GetUserProfile(1));
        }
    }
}
