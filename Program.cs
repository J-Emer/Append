using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Append
{
    class Program
    {
         

        static void Main(string[] args)
        {
            Logger.Log("---Append---", Varbosity.Low);

            CheckArgs(args);
        }

        private static void CheckArgs(string[]args)
        {
            Logger.Log("Args:", Varbosity.Med);
            Logger.Log(args.ToList(), Varbosity.Med);
            Logger.LineBreak();

            if(args.Length == 0)
            {
                Logger.Log("No args", Varbosity.High);
                return;
            }
            if(args.Length < 2)
            {
                Logger.Log("Missing args", Varbosity.High);
                return;
            }

            string _dir = args[0];

            if(args[0] == ".")
            {
                _dir = Environment.CurrentDirectory;
            }

            if(!Directory.Exists(_dir))
            {
                Logger.Log($"Directory: {_dir} does not exist", Varbosity.High);
                return;
            }

            string _appendName = args[1];

            AppendName(_dir, _appendName);
        }


        private static void AppendName(string _dir, string _appendName)
        {
            int i = 0;

            foreach (var item in Directory.GetFiles(_dir))
            {
                string _path = item;
                string _fileName = Path.GetFileNameWithoutExtension(item);
                string _newName = _appendName + "_" + _fileName;
                string _ext = Path.GetExtension(_path);
                string _newPath = Path.Combine(_dir, _newName) + _ext;

                File.Move(_path, _newPath);

                i += 1;
            }

            Logger.Log($"Updated {i} file names", Varbosity.Low);
        }



    }

    public enum Varbosity {High, Med, Low};
}
