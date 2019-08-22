# C# Discord Webhook

simple and easy to use Discord Webhook Libray, just add the cs file into your project!

> usage: 
```csharp
   public static void sendRequest(string URL, string msg)
   {
     using (DiscordWeb dcWeb = new DiscordWeb())
      {
         dcWeb.ProfilePicture = "picture url!";
         dcWeb.UserName = "bot name!";
         dcWeb.WebHook = URL;
         dcWeb.SendMessage(msg);
      }
   }

 sendRequest("webhook url here!", "message!"); 
```


> need help making a discord webhook? vv

![hi](https://i.imgur.com/Cr4zMWs.png)
