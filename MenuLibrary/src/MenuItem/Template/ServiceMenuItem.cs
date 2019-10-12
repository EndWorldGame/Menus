using System;
using System.Collections.Generic;
using System.Text;
using MenuLibrary.src.RunService;

namespace MenuLibrary.src.MenuItem.Template
{
    public class ServiceMenuItem : IMenuItem
    {
        String _name;
        IRunService _runService;

        public ServiceMenuItem(String name, IRunService runService)
        {
            _name = name;
            _runService = runService;
        }

        public string Name()
        {
            return _name;
        }

        public bool Select()
        {
            _runService.Run();
            return true;
        }
    }
}
