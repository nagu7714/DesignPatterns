using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    class InvitationCard
    {

        public string To;
        public string Title;
        public string Content;
        public string SendBy;
        public DateTime Date;
        public String p_To
        {
            get { return To; }
            set { To = value; }
        }
        public String p_Title
        {
            get { return Title; }
            set { Title = value; }
        }
        public String p_content
        {
            get { return Content; }
            set { Content = value; }
        }
        public String p_SendBy
        {
            get { return SendBy; }
            set { SendBy = value; }
        }
        public DateTime p_Date
        {
            get { return Date; }
            set { Date = value; }
        }


        public InvitationCard CloneMe(InvitationCard ob)
        {
            return (InvitationCard)this.MemberwiseClone();
        }

    }
}
