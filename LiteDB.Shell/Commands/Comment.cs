﻿namespace LiteDB.Shell.Commands
{
    internal class Comment : ConsoleCommand
    {
        public override bool IsCommand(StringScanner s)
        {
            return s.Match(@"--");
        }

        public override void Execute(ref IShellEngine engine, StringScanner s, Display display, InputCommand input)
        {
        }
    }
}