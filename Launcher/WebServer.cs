using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher;
public static class WebServer
{
    public static void CreateWebServer()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
            .Build();

        var builder = WebApplication.CreateBuilder();
        string port = config.GetValue<string>("port") ?? "30000";
        string scheme = config.GetValue<string>("scheme") ?? "http";
        string host = config.GetValue<string>("host") ?? "localhost";
        string fullHost = $"{scheme}://{host}:{port}";

        builder.WebHost.UseUrls(fullHost);

        var app = builder.Build();

        app.MapGet("/{wallpaper}/{*filePath}", async context =>
        {
            var req = context.Request;
            var res = context.Response;

            if (req.Path.ToString().Contains("/common/badge/v1/login/info"))
            {
                await res.WriteAsync(@"{ ""retcode"": 0, ""message"": ""OK"", ""data"": { ""game"": ""hk4e"", ""region"": ""os_euro"", ""game_uid"": ""700000000"", ""game_biz"": """", ""level"": 60, ""nickname"": ""Username"", ""region_name"": ""os_euro"", ""type"": 0, ""account_id"": ""6000000"" } }");
                return;
            }
            else if (req.Path.ToString().Contains("/event/merlin_v2/v3/flow/run/hk4e_global"))
            {
                await res.WriteAsync(@"{ ""data"": { ""barriey1_photo1"": """", ""barriey1_status1"": 0, ""barriey2_photo1"": ""https://act-upload.hoyoverse.com/event-ugc-review/2024/03/16/704814986/9604425886e37415b81e37f6905f1dda_746795246449716234.jpeg"", ""barriey2_photo2"": ""https://act-upload.hoyoverse.com/event-ugc-review/2024/03/16/704814986/19ee4f55000ebbf7939f4b2e16d3603f_3678371732281333504.jpeg"", ""barriey2_status1"": 2, ""barriey2_status2"": 2, ""barriey3_photo1"": """", ""barriey3_photo2"": """", ""barriey3_status1"": 0, ""barriey3_status2"": 0, ""code"": ""GCAHHSVZWN"", ""gender"": 2, ""tasks"": { ""data"": [{ ""status"": ""completed"", ""task_id"": 1 }, { ""status"": ""completed"", ""task_id"": 24 }, { ""status"": ""unfinish"", ""task_id"": 25 }, { ""status"": ""completed"", ""task_id"": 26 }, { ""status"": ""unfinish"", ""task_id"": 27 }, { ""status"": ""unfinish"", ""task_id"": 28 }], ""message"": """", ""retcode"": 0 } }, ""message"": ""0"", ""retcode"": 0 }");
                return;
            }
            //event/merlin_v2/v3/flow/run/hk4e_global/e20240126rolewarm/1
            else if (req.Path.ToString().Contains("/device-fp/api/getExtList"))
            {
                if (req.Query.ContainsKey("platform") && req.Query["platform"] == "4")
                    await res.WriteAsync(@"{""retcode"":0,""message"":""OK"",""data"":{""code"":200,""msg"":""ok"",""ext_list"":[""userAgent"",""browserScreenSize"",""maxTouchPoints"",""isTouchSupported"",""browserLanguage"",""browserPlat"",""browserTimeZone"",""webGlRender"",""webGlVendor"",""numOfPlugins"",""listOfPlugins"",""screenRatio"",""deviceMemory"",""hardwareConcurrency"",""cpuClass"",""ifNotTrack"",""ifAdBlock"",""hasLiedLanguage"",""hasLiedResolution"",""hasLiedOs"",""hasLiedBrowser"",""canvas"",""webDriver"",""colorDepth"",""pixelRatio"",""packageName"",""packageVersion"",""webgl""],""pkg_list"":[],""pkg_str"":""/vK5WTh5SS3SAj8Zm0qPWg==""}}");
                else
                    await res.WriteAsync(@"{ ""confirmBtn"": ""Confirm"", ""exitBtn"": ""Quit"", ""gpuAccDisable"": ""Please enable hardware acceleration in your browser to experience smoother animations."", ""ios17Err"": ""Failed to create WebGL. Close the process from the background or use another browser to take part in the event again. (webgl_err_toast)"", ""loadErr"": ""Resource loading error. Please refresh and try again. (load_err_toast)"", ""refreshBtn"": ""Refresh"", ""webglErr"": ""Your current browser version is not the latest, we recommend using other browsers to participate in the event (webgl_err_toast)"" }");
                return;
            }

            if (!int.TryParse(req.Query["fps"], out int fps))
                fps = 60;

            var wall = req.Query.ContainsKey("wall") ? req.Query["wall"][0] : "main";

            string path = "";

            if (req.RouteValues["wallpaper"] != null)
                path = req.RouteValues["wallpaper"].ToString();
            if (req.RouteValues["filePath"] != null)
                path += "/" + req.RouteValues["filePath"].ToString();

            if (!path.Contains('.')) // empty path = requesting index.html
            {
                string w = req.RouteValues["wallpaper"].ToString();
                res.Cookies.Append("wallpaper", w);
                var html = await File.ReadAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "wallpapers", w, "index.html"));
                StringBuilder sb = new StringBuilder();
                sb.Append($"<script>\r\nkot = {{\r\n      host: \"{fullHost}/{w}\",\r\n      wall: \"{wall}\",\r\n      FPS: {fps},");
                foreach (var q in req.Query)
                {
                    if (q.Key.ToLower() == "wall" || q.Key.ToLower() == "fps")
                        continue;

                    sb.Append($"\r\n      {q.Key}: \"{q.Value}\",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append("\r\n    };");
                sb.Append($"\r\n</script>\r\n<style>#frame{{display:{(req.Query.ContainsKey("enableUI") ? "block" : "none")}!important;}} .me-toast{{display:none!important;}}</style>\r\n");
                html = html.Replace("//inject-kot", sb.ToString());
                res.ContentType = "text/html";
                await res.WriteAsync(html);
                return;
            }

            string filePath = path.Split('/')[^1];
            string targetDir = "images";
            string wallpaper = req.Cookies["wallpaper"];

            if (filePath.EndsWith(".js") || filePath.EndsWith(".css"))
                targetDir = "";
            else if (filePath.EndsWith(".json")) // need to read json and replace all URLs inside it
            {
                var jsonText = await File.ReadAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "wallpapers", wallpaper, "public", "json", filePath));

                JObject jsonObject = JObject.Parse(jsonText);
                foreach (var property in jsonObject.Properties())
                {
                    if (property.Value.Type == JTokenType.String && Uri.TryCreate((string)property.Value, UriKind.Absolute, out Uri uri))
                    {
                        UriBuilder uriBuilder = new UriBuilder(uri);
                        uriBuilder.Host = host;
                        uriBuilder.Port = int.Parse(port);
                        uriBuilder.Path = $"{wallpaper}/{uriBuilder.Path}";
                        uriBuilder.Scheme = scheme;
                        property.Value = uriBuilder.Uri.ToString();
                    }
                }

                string formattedJson = JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                await res.WriteAsync(formattedJson);
                return;
            }
            else if (filePath.EndsWith(".mp3") || filePath.EndsWith(".bin") || filePath.EndsWith(".wav"))
                targetDir = "media";

            string absolutePath = Path.Combine(Directory.GetCurrentDirectory(), "wallpapers", wallpaper, "public", targetDir, filePath);
            Console.WriteLine(absolutePath);

            if (File.Exists(absolutePath))
                await res.SendFileAsync(absolutePath);
            else
                res.StatusCode = 404;
        });

        app.MapPost("/h5/upload", async context => await context.Response.WriteAsync("ok"));
        app.Run();
    }
}
