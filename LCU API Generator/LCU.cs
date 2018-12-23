using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using IPath = System.IO.Path;

namespace LCU_API_Generator
{
    public static class LCU
    {
        private static HttpClient Client;

        public static bool Connect()
        {
            var p = Process.GetProcessesByName("LeagueClient");

            if (p.Length == 0)
                return false;

            string lockFilePath;

            try
            {
                lockFilePath = IPath.GetFullPath(IPath.Combine(IPath.GetDirectoryName(p[0].MainModule.FileName), "../../../../../../lockfile"));
            }
            catch
            {
                return false;
            }

            if (!File.Exists(lockFilePath))
                return false;

            string lockFile;

            using (var stream = File.Open(lockFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                lockFile = new StreamReader(stream).ReadToEnd();

            string[] parts = lockFile.Split(':');
            var port = int.Parse(parts[2]);
            var token = parts[3];

            var httpHandler = new HttpClientHandler
            {
                ClientCertificateOptions = ClientCertificateOption.Manual
            };
            httpHandler.ServerCertificateCustomValidationCallback = (a, b, c, d) => true;

            Client = new HttpClient(httpHandler);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes("riot:" + token)));
            Client.BaseAddress = new Uri($"https://127.0.0.1:{port}");

            return true;
        }

        public static Task<string> GetSwagger() => Client.GetStringAsync("swagger/v2/swagger.json");
    }
}
