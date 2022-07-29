using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository;
        public FriendService()
        {
            friendRepository = new FriendRepository();
        }
        public void FriendRegister(FriendRegistrationData friendRegistrationData)
        {
            var friendEntity = new FriendEntity()
            {
                user_id = friendRegistrationData.UserId,
                friend_id = friendRegistrationData.FriendId
            };
            this.friendRepository.Create(friendEntity);
        }
    }
}
