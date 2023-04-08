using Microsoft.Extensions.CommandLineUtils;

var app = new CommandLineApplication();
app.Command("catapult", config => { });
app.Command("snowball", config => { });
//give people help with --help
app.HelpOption("-? | -h | --help");
app.Execute(args);
