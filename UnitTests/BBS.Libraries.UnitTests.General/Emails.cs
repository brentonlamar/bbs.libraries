using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBS.Libraries.Extensions;
using NUnit.Framework;

namespace BBS.Libraries.UnitTests.General
{
    [TestFixture]
    public class Emails
    {
        [Test]
        public void Emails_Can_Be_Serialized_As_Json()
        {
            var mail = new BBS.Libraries.Emails.MailMessage();

            var serializedMessage = "{\"From\":null,\"Sender\":null,\"ReplyToList\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"To\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"CC\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"Bcc\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"Priority\":0,\"DeliveryNotificationOptions\":0,\"Subject\":null,\"SubjectEncoding\":null,\"Headers\":null,\"HeadersEncoding\":null,\"Body\":null,\"BodyEncoding\":null,\"IsBodyHtml\":false,\"Attachments\":{\"$type\":\"BBS.Libraries.Emails.MailMessageAttachmentCollection, BBS.Libraries.Emails\",\"$values\":[]},\"AlternateViews\":[]}";

            var serializedResult = mail.ToJsonString<BBS.Libraries.Emails.MailMessage>();

            Assert.That(serializedResult, Is.EqualTo(serializedMessage));
        }

        [Test]
        public void Emails_Can_Be_Deserialized_From_Json()
        {
            var mail = new BBS.Libraries.Emails.MailMessage();

            var serializedMessage = "{\"From\":null,\"Sender\":null,\"ReplyToList\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"To\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"CC\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"Bcc\":{\"$type\":\"BBS.Libraries.Emails.EmailAddressCollection, BBS.Libraries.Emails\",\"$values\":[]},\"Priority\":0,\"DeliveryNotificationOptions\":0,\"Subject\":null,\"SubjectEncoding\":null,\"Headers\":null,\"HeadersEncoding\":null,\"Body\":null,\"BodyEncoding\":null,\"IsBodyHtml\":false,\"Attachments\":{\"$type\":\"BBS.Libraries.Emails.MailMessageAttachmentCollection, BBS.Libraries.Emails\",\"$values\":[]},\"AlternateViews\":[]}";

            var deserializedResult = serializedMessage.FromJsonString<BBS.Libraries.Emails.MailMessage>();

            Assert.That(deserializedResult.To, Is.EqualTo(mail.To));
            Assert.That(deserializedResult.From, Is.EqualTo(mail.From));
            Assert.That(deserializedResult.Priority, Is.EqualTo(mail.Priority));
            Assert.That(deserializedResult.AlternateViews, Is.EqualTo(mail.AlternateViews));
            Assert.That(deserializedResult.Attachments, Is.EqualTo(mail.Attachments));
            Assert.That(deserializedResult.Bcc, Is.EqualTo(mail.Bcc));
        }


    }
}
