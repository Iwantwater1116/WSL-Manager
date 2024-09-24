using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WSLib
{
    class WSLData
    {
        //WLS Distro資料
        public class DistroList
        {
            public string Name { get; set; }
            public bool State { get; set; }
            public int WSLVersion { get; set; }
        }
    }
    class WSLAPI
    {
        public static List<WSLData.DistroList> getDistro()
        {
            string output = ExcuteWslCommand("wsl -l -v");
            string outputData = (output.Replace("\0", "")).Replace("*","");
            //處理資料
            List<WSLData.DistroList> distroList = new List<WSLData.DistroList>();
            //先分行
            string[] lines = outputData.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            //除去第一行
            for(int i = 1; i<lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = Regex.Matches(line, @"\S+")
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .ToArray();
                WSLData.DistroList newWSL = new WSLData.DistroList();
                newWSL.Name = parts[0] ?? "Unknown";
                newWSL.State = parts[1] == "Running" ? true : false;
                newWSL.WSLVersion = Convert.ToInt32(parts[2] ?? "-1");
                distroList.Add(newWSL);
            }
            return distroList;
        }
        public static string ExcuteWslCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-Command " + command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using(System.IO.StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
