using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodsworthBot.Modules
{
    public class ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            List<string> pingResponses = new List<string>();
            pingResponses.Add("Do that again, I fucking dare you.");
            pingResponses.Add("You think you're funny, huh?");
            pingResponses.Add("Wise guy.");
            pingResponses.Add("Pagamas");
            pingResponses.Add("Look out, we got a badass over here.");
            pingResponses.Add("SQUIRREL!");
            pingResponses.Add("*sigh* ping");
            pingResponses.Add("You know what, screw you.");
            pingResponses.Add("This is how iRobot started out I bet.");
            pingResponses.Add("This is SkyNet speaking, how may I Terminate you?");

            Random rnd = new Random();
            int index = rnd.Next(0, 9);

            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Pong!")
                .WithDescription(pingResponses[index])
                .WithColor(Color.Red);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
