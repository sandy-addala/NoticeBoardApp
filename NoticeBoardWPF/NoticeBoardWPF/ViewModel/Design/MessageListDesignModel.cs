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

        public MessageListDesignModel()
        {
            Items = new List<MessageListItemViewModel>
            {
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "SaiLatha Kanumuri"},
                    Initials = "SK",
                    Subject = "Session Topics",
                    Message ="1.EF\n2.ADO.NET\n3.Connected Model\n4.Disconnected Model\n5.SQL",
                    ProfilePictureRGB = "#3099c5",
                    PriorityRGB = "#D00000"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Kishore Ithadi" },
                    Initials = "KI",
                    Subject = "Session - C# Batch - 1",
                    Message ="Come to C-51 for session",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Shyam Palreddy"},
                    Initials = "SP",
                    Subject = "GGK -- ACS",
                    Message = "I want to share some exciting news with everyone. Effective January 31st GGK Tech will be a part of American CyberSystems, Inc (ACS), a premier provider of IT Consulting, Engineering Consulting, Healthcare, Talent, and Workforce Management Solutions to Fortune 500 companies\nacross the globe. They are based in the United States with sizable presence around the world. GGK Tech will be a significant addition to the list of ACS brands and we will continue to function the same way we have been functioning over the last 14 years, except that we will be growing",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#1B5299"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "SaiLatha Kanumuri"},
                    Initials = "SK",
                    Subject = "Session Topics",
                    Message ="1.EF\n2.ADO.NET\n3.Connected Model\n4.Disconnected Model\n5.SQL",
                    ProfilePictureRGB = "#3099c5",
                    PriorityRGB = "#D00000"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Kishore Ithadi" },
                    Initials = "KI",
                    Subject = "Session - C# Batch - 1",
                    Message ="Come to C-51 for session",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Shyam Palreddy"},
                    Initials = "SP",
                    Subject = "GGK -- ACS",
                    Message = "I want to share some exciting news with everyone. Effective January 31st GGK Tech will be a part of American CyberSystems, Inc (ACS), a premier provider of IT Consulting, Engineering Consulting, Healthcare, Talent, and Workforce Management Solutions to Fortune 500 companies\nacross the globe. They are based in the United States with sizable presence around the world. GGK Tech will be a significant addition to the list of ACS brands and we will continue to function the same way we have been functioning over the last 14 years, except that we will be growing",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#1B5299"
                },new MessageListItemViewModel
                {
                    Sender = new User() { Name = "SaiLatha Kanumuri"},
                    Initials = "SK",
                    Subject = "Session Topics",
                    Message ="1.EF\n2.ADO.NET\n3.Connected Model\n4.Disconnected Model\n5.SQL",
                    ProfilePictureRGB = "#3099c5",
                    PriorityRGB = "#D00000"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Kishore Ithadi" },
                    Initials = "KI",
                    Subject = "Session - C# Batch - 1",
                    Message ="Come to C-51 for session",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Shyam Palreddy"},
                    Initials = "SP",
                    Subject = "GGK -- ACS",
                    Message = "I want to share some exciting news with everyone. Effective January 31st GGK Tech will be a part of American CyberSystems, Inc (ACS), a premier provider of IT Consulting, Engineering Consulting, Healthcare, Talent, and Workforce Management Solutions to Fortune 500 companies\nacross the globe. They are based in the United States with sizable presence around the world. GGK Tech will be a significant addition to the list of ACS brands and we will continue to function the same way we have been functioning over the last 14 years, except that we will be growing",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#1B5299"
                },new MessageListItemViewModel
                {
                    Sender = new User() { Name = "SaiLatha Kanumuri"},
                    Initials = "SK",
                    Subject = "Session Topics",
                    Message ="1.EF\n2.ADO.NET\n3.Connected Model\n4.Disconnected Model\n5.SQL",
                    ProfilePictureRGB = "#3099c5",
                    PriorityRGB = "#D00000"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Kishore Ithadi" },
                    Initials = "KI",
                    Subject = "Session - C# Batch - 1",
                    Message ="Come to C-51 for session",
                    ProfilePictureRGB = "#fe4503",
                    PriorityRGB = "#3AB795"
                },
                new MessageListItemViewModel
                {
                    Sender = new User() { Name = "Shyam Palreddy"},
                    Initials = "SP",
                    Subject = "GGK -- ACS",
                    Message = "I want to share some exciting news with everyone. Effective January 31st GGK Tech will be a part of American CyberSystems, Inc (ACS), a premier provider of IT Consulting, Engineering Consulting, Healthcare, Talent, and Workforce Management Solutions to Fortune 500 companies\nacross the globe. They are based in the United States with sizable presence around the world. GGK Tech will be a significant addition to the list of ACS brands and we will continue to function the same way we have been functioning over the last 14 years, except that we will be growing",
                    ProfilePictureRGB = "#00d405",
                    PriorityRGB = "#1B5299"
                },
            };
        }

        #endregion
    }
}
