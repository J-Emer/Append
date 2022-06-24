using System.IO;

namespace Append.Commands
{
    public class Last : ICommand
    {
        public string Name{get;set;} = "Last";
        public string Description{get;set;} = "Appends name to End of file name";
        public string Execute(string[] args)
        {
            string _output = string.Empty;

            if(args.Length < 2)
            {
                _output = "Missing args";
                return _output;
            }

            string _appendName = args[0];

            string _dir = args[1];
            if(_dir == ".")
            {
                _dir = System.Environment.CurrentDirectory;
            }
            if(!Directory.Exists(_dir))
            {
                _output = $"Could not find Directory: {_dir}";
                return _output;
            }
            

            int i = 0;

            foreach (var item in Directory.GetFiles(_dir))
            {
                string _path = item;
                string _fileName = Path.GetFileNameWithoutExtension(item);
                string _newName = _fileName + "_" + _appendName;
                string _ext = Path.GetExtension(_path);
                string _newPath = Path.Combine(_dir, _newName) + _ext;

                File.Move(_path, _newPath);

                i += 1;
            }

            return $"{i} Files have been Renamed";
        }
    }
}


