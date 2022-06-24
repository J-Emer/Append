using System.Collections.Generic;
using Append.Commands;


namespace Append
{
    class Program
    {

        //"(first/last) | append name | directory"

        static void Main(string[] args)
        {
            new CommandProcessor(new List<ICommand>
                                                    {
                                                        new Help(),
                                                        new First(),
                                                        new Last(),
                                                        new List(),
                                                        new Version(),
                                                        new About()
                                                    });

            CommandProcessor.Instance.Process(args);
        }

    }

    public enum Varbosity {High, Med, Low};
}
