using System;
using System.Text;
using System.Linq;

namespace Append.Commands
{
    public class Help : ICommand
    {
        public string Name{get;set;} = "Help";
        public string Description{get;set;} = "Shows Help Message";

        public string Execute(string[] args)
        {
            StringBuilder _sb = new StringBuilder();

            _sb.Append("Useage:");
            _sb.Append(Environment.NewLine);
            _sb.Append("    Append [Options] [Append Name] [Directory]");
            _sb.Append(Environment.NewLine);
            _sb.Append(Environment.NewLine);


            _sb.Append("Options:");
            _sb.Append(Environment.NewLine);
            _sb.Append("    First: Appends name to the Beginning of file");
            _sb.Append(Environment.NewLine);
            _sb.Append("    Last: Appends name to the End of file");


            return _sb.ToString();
        }

        public override string ToString()
        {
            return $"Name: {Name} | Desc: {Description}";
        }
    }
    public class help : Help
    {
        public help()
        {
            this.Name = "help";
        }
    }
}


