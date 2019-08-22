using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWebhook
{
    public class DiscordWeb : IDisposable
    {
        private readonly WebClient WC;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }

        public DiscordWeb()
        {
            WC = new WebClient();
        }

        public void SendMessage(string msgSend)
        {
            discordValues.Add("username", UserName);
            discordValues.Add("avatar_url", ProfilePicture);
            discordValues.Add("content", msgSend);

            WC.UploadValues(WebHook, discordValues);
        }

        public void Dispose()
        {
            WC.Dispose();
        }
    }
}
