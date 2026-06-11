#nullable enable

using System.CommandLine;

namespace Fireworks.CLI.Commands;

internal static class AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioCreateTranscriptionCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateTranslationCommandApiCommand.Create());
        return command;
    }
}