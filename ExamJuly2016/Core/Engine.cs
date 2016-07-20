using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.ConsoleReader;
using OOPBasicsExam.Utils.Repositories;

namespace OOPBasicsExam.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandDispatcher commandDispatcher;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;
        private bool isRunning;

        public Engine(
                      ICommandDispatcher commandDispatcher,
                      IInputReader reader,
                      IOutputWriter writer)  
        {
            this.commandDispatcher = commandDispatcher;
            this.reader = reader;
            this.writer = writer;
            this.commandDispatcher.HardwRepository = HardwareRepositoty.Instance;
            this.isRunning = true;
        }


        public void Run()
        {
            this.commandDispatcher.SeedCommands();
            string pattern = @"^([a-zA-Z\s]+)\(*([\s\S]*?)\)*$";
            Regex regex = new Regex(pattern);
            string line = reader.ReadLine();
            while (isRunning && !string.IsNullOrEmpty(line))
            {
                
                Match match = regex.Match(line);
                string command = match.Groups[1].ToString();
                string group2 = match.Groups[2].ToString();
                List<string> commandArgs = new List<string>();
                commandArgs.Add(command);
                if (!string.IsNullOrEmpty(group2))
                {
                    string[] args = Regex.Split(group2, ",\\s+");
                    foreach (var c in args)
                    {
                        commandArgs.Add(c);
                    }
                }
                try
                {
                    this.commandDispatcher.DispatchCommand(commandArgs.ToArray());
                }
                catch (NotSupportedException)
                {
                    //
                }  

                line = reader.ReadLine();
            }

        }

        public void Stop()
        {
            this.isRunning = false;
        }
    }
}
