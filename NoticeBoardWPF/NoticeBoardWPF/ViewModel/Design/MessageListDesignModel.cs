using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardWPF
{
    class MessageListDesignModel : MessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageListDesignModel Instance => new MessageListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageListDesignModel()
        {
            Items = new List<MessageListItemViewModel>
            {
                new MessageListItemViewModel
                {
                    Name = "Luke",
                    Initials = "LM",
                    Subject = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "#3099c5",
                    PriorityRGB = "#D00000"
                },
                new MessageListItemViewModel
                {
                    Name = "Jesse",
                    Initials = "JA",
                    Subject = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"
                },
                new MessageListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Subject = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#1B5299"
                },
                new MessageListItemViewModel
                {
                    Name = "Luke",
                    Initials = "LM",
                    Subject = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "#3099c5",
                    PriorityRGB = "#3E4E50"
                },
                new MessageListItemViewModel
                {
                    Name = "Jesse",
                    Initials = "JA",
                    Subject = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"
                },
                new MessageListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Subject = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#3AB795"

                },
                new MessageListItemViewModel
                {
                    Name = "Luke",
                    Initials = "LM",
                    Subject = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "#3099c5"
                },
                new MessageListItemViewModel
                {
                    Name = "Jesse",
                    Initials = "JA",
                    Subject = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"

                },
                new MessageListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Subject = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#3AB795"

                },
            };
        }

        #endregion
    }
}
