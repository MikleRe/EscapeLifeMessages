﻿using System;

namespace EscapeLife.Messages.Chat
{
    /// <summary>
    /// Message sent by the server to the clients containing a Uri to be displayed
    /// </summary>
    public partial class VideoMessage : MessageBase
    {
        public Uri URL { get; set; }
            
        public override string ToString()
        {
            return $"{base.ToString()} a {GetType().Name} with URL '{URL}'";
        }
    }
}
