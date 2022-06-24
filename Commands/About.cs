using System.Text;

namespace Append.Commands
{
    public class About : ICommand
    {
        public string Name{get;set;} = "About";
        public string Description{get;set;} = "Shows About Information";

        public string Execute(string[] args)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.Append("About:");
            _sb.Append(System.Environment.NewLine);
            _sb.Append("    Append: Simple tool I made to Append a specified name to either the Start or End all files in a specific Directory");
            _sb.Append(System.Environment.NewLine);
            _sb.Append(System.Environment.NewLine);


            var _version = CommandProcessor.Instance.Commands.Find(x => x.Name == "Version");
            var _lists = CommandProcessor.Instance.Commands.Find(x => x.Name == "List");
            var _help = CommandProcessor.Instance.Commands.Find(x => x.Name == "Help");

            string _vString = _version.Execute(args);
            string _lString = _lists.Execute(args);
            string _hString = _help.Execute(args);


            _sb.Append(_vString);
            _sb.Append(System.Environment.NewLine);
            _sb.Append(_lString);
            _sb.Append(System.Environment.NewLine);
            _sb.Append(_hString);

            return _sb.ToString();
        }
    }
}


