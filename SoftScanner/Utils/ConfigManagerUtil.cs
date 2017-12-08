using Newtonsoft.Json;
using SoftScanner.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftScanner.Utils
{
    class ConfigManagerUtil
    {
        static public Boolean saveConfig(String fileName, IReadOnlyList<Channel> channelList)
        {
            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, channelList);
                }
            }

            return true;
        }

        static public Boolean loadConfig(string fileName, Scanner destScanner)
        {
            string filetext = File.ReadAllText(fileName);

            var channels = JsonConvert.DeserializeObject<List<Channel>> (filetext);

            destScanner.clearChannels();

            foreach (var loaded_channel in channels)
            {
                destScanner.addChannel(loaded_channel);
            }
           
            return true;
        }
    }
}
