using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models.Entities
{
    public class FriendRequest
    {
        public int Id { get; set; }

        public User Sender { get; set; }

        public int? SenderId { get; set; }

        public User Receiver { get; set; }

        public int? UserId { get; set; }
    }
}
