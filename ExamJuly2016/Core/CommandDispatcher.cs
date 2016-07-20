using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Core.Commands;
using OOPBasicsExam.Interfaces;

namespace OOPBasicsExam.Core
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IDictionary<string, ICommand> commandsByName;

        public CommandDispatcher()
        {
            this.commandsByName = new Dictionary<string, ICommand>();
        }

        public IOutputWriter Writer { get; set; }

        public IStopable Stop { get; set; }

        public IRepository<IHardware> HardwRepository { get; set; }

        public virtual void DispatchCommand(string[] commandArgs)
        {
            string commandName = commandArgs[0];
            if (!this.commandsByName.ContainsKey(commandName))
            {
                throw new NotSupportedException(
                    "Command is not supported by engine");
            }

            var command = this.commandsByName[commandName];
            command.Hardweres = this.HardwRepository;
            command.Execute(commandArgs);
        }

        public virtual void SeedCommands()
        {
            this.commandsByName["RegisterPowerHardware"] = new RegisterPowerHardwareCommand();
            this.commandsByName["RegisterHeavyHardware"] = new RegisterHeavyHardwareCommand();
            this.commandsByName["RegisterExpressSoftware"] = new RegisterExpressSoftwareCommand();
            this.commandsByName["RegisterLightSoftware"] = new RegisterLightSoftwareCommand();
            this.commandsByName["ReleaseSoftwareComponent"] = new ReleaseSoftwareComponentCommand();
            this.commandsByName["Analyze"] = new AnalyzeCommand(this.Writer);
            this.commandsByName["System Split"] = new SystemSplitCommand(this.Writer,this.Stop);
            this.commandsByName["Dump"] = new DumpCommand();
            this.commandsByName["Restore"] = new RestoreCommand();
            this.commandsByName["Destroy"] = new DestroyCommand();
            this.commandsByName["DumpAnalyze"] = new DumpAnalyzeCommand();
        }
    }
}
