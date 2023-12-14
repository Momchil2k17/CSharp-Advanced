using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail) 
        {
            if (Inbox.Count<Capacity)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender) 
        {
            return Inbox.Remove(Inbox.FirstOrDefault(x => x.Sender == sender));
        }
        public int ArchiveInboxMessages() 
        {
            foreach (var item in Inbox)
            {
                Archive.Add(item);
            }
            Inbox = new List<Mail>();
            return Archive.Count;
        }
        public string GetLongestMessage() 
        {
            return Inbox.MaxBy(x => x.Body.Length).ToString();
        }
        public string InboxView() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var item in Inbox)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
