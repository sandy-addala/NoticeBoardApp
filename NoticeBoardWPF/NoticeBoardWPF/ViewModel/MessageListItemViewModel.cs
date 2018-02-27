using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardWPF
{
    class MessageListItemViewModel
    {
        /// <summary>
        /// The display name of this chat list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The latest message from this chat
        /// </summary>
        public string Subject { get; set; }

        public string Message { get; set; }

        /// <summary>
        /// The initials to show for the profile picture background
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture
        /// For example FF00FF for Red and Blue mixed
        /// </summary>
        public string ProfilePictureRGB { get; set; }
        /// <summary>
        /// The message's priority color.
        /// </summary>
        public string PriorityRGB { get; set; }

        /// <summary>
        /// True if there are unread messages in this chat 
        /// </summary>
        public bool Isread { get; set; }

    }
}
