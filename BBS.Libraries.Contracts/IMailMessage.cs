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
//using System;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Net.Mail;
//using System.Text;
//using System.Threading.Tasks;

//namespace BBS.Libraries.Contracts
//{
//    public interface IMailMessage
//    {

//        EmailAddress From { get; set; }


//        EmailAddress Sender { get; set; }


//        EmailAddressCollection ReplyToList { get; set; }


//        EmailAddressCollection To { get; set; }


//        EmailAddressCollection CC { get; set; }


//        EmailAddressCollection Bcc { get; set; }


//        MailPriority Priority { get; set; }


//        DeliveryNotificationOptions DeliveryNotificationOptions { get; set; }


//        string Subject { get; set; }


//        int? SubjectEncoding { get; set; }
        
//        NameValueCollection Headers { get; }


//        int? HeadersEncoding { get; set; }


//        string Body { get; set; }


//        int? BodyEncoding { get; set; }


//        bool IsBodyHtml { get; set; }


//        MailMessageAttachmentCollection Attachments { get; set; }


//        MailMessageAlternateViewCollection AlternateViews { get; set; }
//    }
//}
