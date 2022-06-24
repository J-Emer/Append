using System;
using System.Collections.Generic;
using System.Linq;

using Append.Commands;

namespace Append
{
    public class CommandProcessor
    {
        public static CommandProcessor Instance;
        public List<ICommand> Commands
        {
            get
            {
                return _commands;
            }
        }
        private List<ICommand> _commands;
        public CommandProcessor(List<ICommand> _commands)
        {
            this._commands = _commands;
            Instance = this;
        }

        public void Process(string[] args)
        {
            /*if(args.Length < 3)
            {
                Logger.Log("Missing Args", Varbosity.High);
                return;
            }*/

            string _commandName = GetCommandName(args);
            
            ICommand _command = this._commands.Where(x => x.Name == _commandName).FirstOrDefault();
            if(_command == null)
            {
                Logger.Log($"ERROR: Command {_commandName} NOT found", Varbosity.High);
                return;
            }
            
            string[] _cmdArgs = GetArgs(args);


            string _outputCommand = string.Empty;

            try
            {
                _outputCommand = _command.Execute(_cmdArgs);
            }
            catch (System.Exception e)
            {
                Logger.Log($"ERROR: {e}", Varbosity.High);
                return;
            }

            Logger.Log(_outputCommand, Varbosity.Low);
        }
        private string GetCommandName(string[] args)
        {
            return args[0];
        }
        private string[] GetArgs(string[] args)
        {
            return args.Skip(1).ToArray();
        }
    }

}


