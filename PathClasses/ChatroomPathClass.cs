using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatAPI.Models
{
    public partial class Chatroom
    {
        public string GetLastMessage
        {
            get
            {
                string message = "Ничего нет";
                try
                {
                    message = ChatMessage.LastOrDefault()?.TextMessage ?? "нет сообщений";
                    return message;
                }
                catch
                {
                    return message;
                }
            }
        }
    }
}