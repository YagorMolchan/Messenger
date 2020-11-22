using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public User Sender { get; set; }

        public int? SenderId { get; set; }

        public User Receiver { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set; }

        public bool Seen { get; set; }
    }
}
