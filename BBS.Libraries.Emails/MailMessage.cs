//-----------------------------------------------------------------------
//    MIT License
//
//    Copyright (c) 2016 Betabyte Software
//
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.
//-----------------------------------------------------------------------

using System;
using System.Collections.Specialized;
using System.Net.Mail;
using BBS.Libraries.Contracts;

namespace BBS.Libraries.Emails
{
    public class MailMessage //: IMailMessage
    {
        public IEmailAddress From { get; set; }

        public IEmailAddress Sender { get; set; }

        public IEmailAddressCollection ReplyToList { get; set; }

        public IEmailAddressCollection To { get; set; }

        public IEmailAddressCollection CC { get; set; }

        public IEmailAddressCollection Bcc { get; set; }

        public MailPriority Priority { get; set; }

        public DeliveryNotificationOptions DeliveryNotificationOptions { get; set; }

        public string Subject { get; set; }

        public int? SubjectEncoding { get; set; }

        public NameValueCollection Headers { get; private set; }

        public int? HeadersEncoding { get; set; }

        public string Body { get; set; }

        public int? BodyEncoding { get; set; }

        public bool IsBodyHtml { get; set; }

        public IMailMessageAttachmentCollection Attachments { get; set; }
        
        public MailMessageAlternateViewCollection AlternateViews { get; set; }

        public MailMessage()
        {
            To = new EmailAddressCollection();
            Bcc = new EmailAddressCollection();
            CC = new EmailAddressCollection();
            ReplyToList = new EmailAddressCollection();
            AlternateViews = new MailMessageAlternateViewCollection();
            Attachments = new MailMessageAttachmentCollection();
        }

        public System.Net.Mail.MailMessage Message()
        {
            var result = new System.Net.Mail.MailMessage();
            
            if (this.From != null)
            {
                result.From = new MailAddress(this.From.Value);
            }
            else if (result.From != null)
            {
                result.From = new MailAddress(result.From.Address);
            }
            else
            {
                throw new ArgumentException("You must either specify 'From' or set your 'system.net > mailSettings > smtp from' app key");
            }
            

            foreach (var to in To)
            {
                result.To.Add(new MailAddress(to.Value));
            }

            foreach (var bcc in Bcc)
            {
                result.Bcc.Add(new MailAddress(bcc.Value));
            }

            foreach (var cc in CC)
            {
                result.CC.Add(new MailAddress(cc.Value));
            }

            foreach (var replyTo in ReplyToList)
            {
                result.ReplyToList.Add(new MailAddress(replyTo.Value));
            }

            if (this.Priority != null)
            {
                result.Priority = this.Priority;
            }
            if (this.DeliveryNotificationOptions != null)
            {
                result.DeliveryNotificationOptions = this.DeliveryNotificationOptions;
            }

            result.Subject = this.Subject;
            result.Body = this.Body;
            result.IsBodyHtml = this.IsBodyHtml;

            foreach (var alternateView in AlternateViews)
            {
                result.AlternateViews.Add(alternateView.XAlternateView);
            }

            foreach (var attachment in Attachments)
            {
                result.Attachments.Add(attachment.XAttachment);
            }

            return result;
        }
    }
}
