using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace MemcachedConsole.Email
{
    public class Email
    {

        public void SendEmail()
        {
            
            //string t1=System.Environment.CurrentDirectory;
            //string t2 = Assembly.GetExecutingAssembly().Location;
            //string t3 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            //string t4 = System.Environment.CurrentDirectory;
            //string t5 = System.AppDomain.CurrentDomain.BaseDirectory;
            //string t6 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            //string t7 = System.Windows.Forms.Application.StartupPath;
            //string t8 = System.Windows.Forms.Application.ExecutablePath;
            //string t9 = System.IO.Directory.GetCurrentDirectory();

            string fileName = @"D:\MyStudy\MemcachedConsole\MemcachedConsole\Email\MemberRegisterEMailTemplate.html";

            //string newPath = System.IO.Path.Combine(activeDir, "mySubDirOne");

            //string path = System.Windows.Forms.Application.StartupPath + fileName;
            //System.IO.Directory.SetCurrentDirectory(path);

            //string path = Environment.CurrentDirectory+fileName;
            // 准备邮件内容
            string mailBody = System.IO.File.ReadAllText(fileName);
            mailBody = mailBody.Replace("{{Name}}", "Neil-test");
            mailBody = mailBody.Replace("{{RegisterOn}}", DateTime.Now.ToString("F"));
            //var auth_url = new UriBuilder()
            //{
            //    //Path = Url.Action("ValidateRegister", new { id = 1212 }),
            //    Path = System.Web.HttpContext.Current.Request.Url+"id=123",
            //    Query = ""
            //};
            string auth_url = "skynibaoshan.vicp.cc"+ "?id=123";
            mailBody = mailBody.Replace("{{AUTH_URL}}", auth_url.ToString());

            // 发送邮件给会员
            try
            {
                string fromEmail = "1303580180@qq.com";
                string fromPassword = "xikfyumypshhjihf";
                string toEmail = "neil.ni@akmii.com";
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Host = "smtp.qq.com";
                SmtpServer.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);
                

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "【我的电子商务网站】会员注册确认信";
                mail.Body = mailBody;
                mail.IsBodyHtml = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
                //发生邮件寄送失败，需记录进资料库检测，以免有会员登录失败
            }
        }

        public void SendEmial2()
        {
            MailMessage mm = new MailMessage();
            MailAddress Fromma = new MailAddress("1303580180@qq.com");
            MailAddress Toma = new MailAddress("neil.ni@akmii.com", null);
            mm.From = Fromma;
            //收件人
            mm.To.Add("neil.ni@akmii.com");
            //邮箱标题
            mm.Subject = "Hello Dear:";
            mm.IsBodyHtml = true;
            //邮件内容
            mm.Body = "你好Mr流星！";
            //内容的编码格式
            mm.BodyEncoding = System.Text.Encoding.UTF8;
            //mm.ReplyTo = Toma;
            //mm.Sender =Fromma;
            //mm.IsBodyHtml = false;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            mm.CC.Add(Toma);
            SmtpClient sc = new SmtpClient();
            
            //sc.UseDefaultCredentials = false;     
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "1303580180@qq.com";//你的邮箱地址
            nc.Password = "xikfyumypshhjihf";//你的邮箱密码,这里的密码是xxxxx@qq.com邮箱的密码，特别说明下~
            sc.EnableSsl = true;
            sc.UseDefaultCredentials = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.Credentials = nc;
            //如果这里报mail from address must be same as authorization user这个错误，是你的QQ邮箱没有开启SMTP，
            //到你自己的邮箱设置一下就可以啦！在帐户下面,如果是163邮箱的话，下面该成smtp.163.com
            sc.Host = "smtp.qq.com";
            sc.Send(mm);
        }

    }
}
