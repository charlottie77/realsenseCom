using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using static PXCMFaceData;

namespace DF_FaceTracking.cs
{
    class JsonPrinter
    {
        public void JsonPrint(DataCapsor dc)
        {
            string output = JsonConvert.SerializeObject(dc);
            //Console.WriteLine(output);
        }
        public string getString(DataCapsor dc)
        {
            string output = JsonConvert.SerializeObject(dc);
            return output;
        }
    }
}
