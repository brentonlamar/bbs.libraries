using System.Net.Mail;

namespace BBS.Libraries.Contracts
{
    public interface IMailMessageAttachment
    {
        byte[] Content { get; set; }

        string ContentType { get; set; }

        string Name { get; set; }

        Attachment XAttachment { get; set; }
    }
}