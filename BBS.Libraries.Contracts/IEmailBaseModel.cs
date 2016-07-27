using System.Net.Mail;

namespace BBS.Libraries.Contracts
{
    public interface IEmailBaseModel : IRazorContentModel
    {
        IEmailAddress FromEmailAddress { get; }
        IEmailAddressCollection ToEmailAddressCollection { get; }
        IEmailAddressCollection CcEmailAddressCollection { get; }
        IEmailAddressCollection BccEmailAddressCollection { get; }
        IMailMessageAttachmentCollection Attachments { get; }
        MailPriority Priority { get; }
    }
}
