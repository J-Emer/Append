using System.Text;

namespace Append.Commands
{
    public class Version : ICommand
    {
        public string Name{get;set;} = "Version";
        public string Description{get;set;} = "Displays Version Number";

        public string Execute(string[] args)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.Append("Version: ");
            _sb.Append(System.Environment.NewLine);
            _sb.Append("    V 0.0.1");
            _sb.Append(System.Environment.NewLine);
            
            return _sb.ToString();
        }

        public override string ToString()
        {
            return $"Name: {Name} | Desc: {Description}";
        }
    }
}


