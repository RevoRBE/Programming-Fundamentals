using System;

namespace URL_Parser
{
    public class URL_Parser
    {
        public static void Main()
        {
            string[] url = Console.ReadLine()
                .Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string protocol = url[0].Replace(":", "");
            string server = url[1];
            string resource = url[2];
            for (int i = 3; i < url.Length; i++)
                resource = string.Join("/", resource, url[i]);
            Console.WriteLine("[protocol]=\"{0}\"", protocol);
            Console.WriteLine("[server]=\"{0}\"", server);
            Console.WriteLine("[resource]=\"{0}\"", resource);
        }
    }
}