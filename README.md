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


![step1](https://i.imgur.com/Mr2JdJ4.png)
![step2](https://i.imgur.com/riLtEXh.png)
![step3](https://i.imgur.com/YOD0B7h.png)
![step4](https://i.imgur.com/19AmLvx.png)
![step5](https://i.imgur.com/SErWOPY.png)

> then copy the webhook url and you're done!
