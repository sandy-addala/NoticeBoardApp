using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NoticeBoardWPF
{
    class Temp
    {
        private ListView listView;

        public Temp(ListView listView)
        {
            this.listView = listView;
        }

        public void Add()
        {
            List<MessageItem> items = new List<MessageItem>();
            for (int i = 1; i < 25; i++)
            {
                items.Add(new MessageItem() { Sender = "Kishore Babu Ithadi", Time = "5:00", Date = "14-2-18", Subject = "C# Batch -1", Message = "Come to C-51 for session", ColorHex = "#D00000" });
                items.Add(new MessageItem() { Sender = "Sailatha Kanumuri  ", Time = "10: 06", Date = "13-2-18", Subject = "Session Topics", Message = "1.Delegates (Action,Func,Predicate, Multicast)\n2.Lamda Expression\n3.Anonymous Method\n4.Events", ColorHex = "#3AB795" });
                items.Add(new MessageItem() { Sender = "Rayhaan Piraani", Time = "5:00", Date = "14-2-18", Subject = "Lunch chale!", Message = "Bohut hogaya aaj android", ColorHex = "#1B5299" });
                items.Add(new MessageItem() { Sender = "Shyam Palreddy", Time = "8:00", Date = "12-2-18", Subject = "GGK Tech -- ACS ", Message = "I want to share some exciting news with everyone. Effective January 31st GGK Tech will be a part of American CyberSystems, Inc (ACS), a premier provider of IT Consulting, Engineering Consulting, Healthcare, Talent, and Workforce Management Solutions to Fortune 500 companies\nacross the globe. They are based in the United States with sizable presence around the world. GGK Tech will be a significant addition to the list of ACS brands and we will continue to function the same way we have been functioning over the last 14 years, except that we will be growing ", ColorHex = "#3E4E50" });
            }
            listView.ItemsSource = items;
        }
    }

    public class MessageItem
    {
        public string Sender { get; set; }

        public string Time { get; set; }

        public string Date { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string ColorHex { get; set; }
    }

    public class User1
    {
        public string Sender { get; set; }

    }
}
