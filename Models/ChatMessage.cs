//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChatMessage
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdChatRoom { get; set; }
        public string TextMessage { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    
        public virtual Chatroom Chatroom { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
