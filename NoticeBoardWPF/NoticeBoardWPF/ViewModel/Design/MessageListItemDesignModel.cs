using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoardWPF
{
    class MessageListItemDesignModel : MessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageListItemDesignModel Instance => new MessageListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageListItemDesignModel()
        {
            Initials = "SK";
            Name = "SaiLata Kanumuri";
            Subject = "Session Topics";
            ProfilePictureRGB = "#3099c5";
        }

        #endregion
    }
}
