using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azpetrol
{
    class FileHelper
    {

        public void JsonSerialize(string bill)
        {
            string fileName = Convert.ToString(DateTime.Now.ToString("MMM-dd-yyyy-hh-mm"));
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(fileName + ".json")) 
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, bill);
                    System.Windows.Forms.MessageBox.Show("Transaction is completed");
                }
            }
        }
        

    }
}
