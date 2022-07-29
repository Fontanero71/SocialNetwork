using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendRegistrationView
    {
        FriendService friendService;
        public UserFriendRegistrationView(FriendService friendService)
        {
            this.friendService = friendService;
        }

        public void Show(User user)
        {
            var friendRegistrationData = new FriendRegistrationData();

            friendRegistrationData.UserId = user.Id;

            Console.WriteLine("Введите email друга");
            string friendEmail = Console.ReadLine();

            UserService userService = new UserService();

            
            var friendUser = userService.FindByEmail(friendEmail);

            if (friendUser == null)
                AlertMessage.Show("UserNotFound");
            else
            {
                friendRegistrationData.FriendId = friendUser.Id;
                this.friendService.FriendRegister(friendRegistrationData);
                Console.WriteLine($"{friendUser.FirstName} {friendUser.LastName} занесен в список ваших друзей");
                Console.WriteLine();
            }
                
        }
    }
}
