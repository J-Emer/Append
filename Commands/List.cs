using System.Text;

namespace Append.Commands
{
    public class List : ICommand
    {
        public string Name{get;set;} = "List";
        public string Description{get;set;} = "List all avaliable Commands";

        public string Execute(string[] args)
        {
            StringBuilder _sb = new StringBuilder();

            _sb.Append("Commands: ");
            _sb.Append(System.Environment.NewLine);

            foreach (var item in CommandProcessor.Instance.Commands)
            {
                _sb.Append($"   {item.Name}:    {item.Description}");
                _sb.Append(System.Environment.NewLine);
            }

            return _sb.ToString();
        }

        public override string ToString()
        {
            return $"Name: {Name} | Desc: {Description}";
        }
    }
}


