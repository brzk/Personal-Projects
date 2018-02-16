using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitlesNameApplication
{
    public class ChangeSubtitles
    {

        static string moviePattern = @"(.+)(s|S)([0-9]+)(e|E)([0-9]+)(.+)\.mkv$";
        static string subtitlePattern = @"(.+)(s|S)([0-9]+)(e|E)([0-9]+)(.+)\.srt$";

        public static void change(string i_Directory, string i_MovieName)
        {
            System.Text.RegularExpressions.Match movieMatch = Regex.Match(i_MovieName, moviePattern, RegexOptions.IgnoreCase);

            if (movieMatch.Success)
            {
                string startName = movieMatch.Groups[1].Value;
                string seasonLetter = movieMatch.Groups[2].Value;
                string seasonNumber = movieMatch.Groups[3].Value;
                string episodeLetter = movieMatch.Groups[4].Value;
                string episodeNumber = movieMatch.Groups[5].Value;
                string endName = movieMatch.Groups[6].Value;

                DirectoryInfo d = new DirectoryInfo(i_Directory);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    string fd = f.Name;

                    long s = f.Length;

                    Match subtitleMatch = Regex.Match(fd, subtitlePattern, RegexOptions.IgnoreCase);
                    if (subtitleMatch.Success)
                    {
                        string episodeSubtitleNumber = subtitleMatch.Groups[5].Value;
                        string newPath = i_Directory + "\\" + startName + seasonLetter + seasonNumber + episodeLetter + episodeSubtitleNumber + endName + ".srt";
                        File.Move(f.FullName, newPath);
                    }
                }
            }

            MessageBox.Show("done");
        }
    }
}
