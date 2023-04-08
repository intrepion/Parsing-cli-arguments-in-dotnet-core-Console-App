using Microsoft.Extensions.CommandLineUtils;

var app = new CommandLineApplication();
var catapult = app.Command("catapult", config =>
{

});
catapult.Command("list", config =>
{
    config.OnExecute(() =>
    {

        config.Description = "list catapults";
        Console.WriteLine("a");
        Console.WriteLine("b");
        return 0;
    });
});
catapult.Command("add", config =>
{
    config.Description = "Add a catapult";
    var arg = config.Argument("name", "name of the catapult", false);
    config.OnExecute(() =>
    {
        if (!string.IsNullOrWhiteSpace(arg.Value))
        {
            //add snowballs somehow (not showing persistence here)
            Console.WriteLine($"added {arg.Value}");
            return 0;
        }
        return 1;


    });
});
app.Command("snowball", config => { });
//give people help with --help
app.HelpOption("-? | -h | --help");
app.Execute(args);
