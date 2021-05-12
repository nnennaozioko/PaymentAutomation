using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LongRichAutomationUI.Common.Utilities
{
    class FileLocations
    {

        //public string GetTestDataLocation()
        //{
        //    return Directory.GetParent(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString(), @"..\..\")) + @"\TestData\";
        //}


        public string GetFolderLocation(string folder)
        {
            return Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).ToString()) + @"\" + folder + @"\";

        }

    }
}
