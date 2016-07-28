using System.Text.RegularExpressions;

namespace BBS.Libraries.Contracts
{
    public interface IEmailAddress
    {
        string Domain { get; set; }
        string MailBox { get; set; }
        bool IsValid { get; set; }
        string Value { get; set; }
    }
}
