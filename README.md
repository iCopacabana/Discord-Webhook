# C# Discord Webhook

Simple y fácil de usar; librería de Discord Webhook. Solo agrega el archivo .cs a tu proyecto.

> USO: 
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
![result](https://i.imgur.com/lAX0PBt.png)
