using GlassLCU;
using GlassLCU.API.Interfaces;
using System;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new LeagueClient();
            var tcs = new TaskCompletionSource<bool>();

            Console.WriteLine("Connecting...");
            client.BeginTryInit(InitializeMethod.Lockfile, taskCompletionSource: tcs);

            var result = await tcs.Task;
            Console.WriteLine("Connected!");

            await Riotclient.PostRiotclientKillUx();

            string str = await client.GetSwaggerJson();
        }
    }
}
