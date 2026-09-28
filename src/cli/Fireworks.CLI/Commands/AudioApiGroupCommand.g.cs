#nullable enable

using System.CommandLine;

namespace Fireworks.CLI.Commands;

internal static partial class AudioApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioCreateTranscriptionCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateTranslationCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}