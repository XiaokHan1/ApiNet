using ChatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatAPI.Model
{
    public partial class ResponceChatRoom
    {
        public ResponceChatRoom(Chatroom chatroom)
        {
            id = chatroom.Id;
            Topic = chatroom.Topic;
            GetLastMessage = chatroom.GetLastMessage;
        }
        public int id { get; set; }
        public string Topic { get; set; }
        public string GetLastMessage { get; set; }
    }
}