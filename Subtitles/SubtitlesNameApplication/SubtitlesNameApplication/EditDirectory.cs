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
    public class EditDirectory
    {
        private static string mkvPattern = @"(.+)\.mkv$";
        private static string srtPattern = @"(.+)\.srt$";
        private static string moviePattern = @"(.+)(s|S)([0-9]+)(e|E)([0-9]+)(.+)\.mkv$";
        private static string subtitlePattern = @"(.+)(s|S)([0-9]+)(e|E)([0-9]+)(.+)\.srt$";

        public static void ConvertSubtitlesNameFromMoviesName(string i_Directory)
        {
            DirectoryInfo directory = new DirectoryInfo(i_Directory);
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                string nameFile = file.Name;
                Match mkvMatch = Regex.Match(nameFile, mkvPattern, RegexOptions.IgnoreCase);

                if (mkvMatch.Success)
                {
                    Match movieMatch = Regex.Match(nameFile, moviePattern, RegexOptions.IgnoreCase);

                    if (movieMatch.Success)
                    {
                        string movieStartName = movieMatch.Groups[1].Value;
                        string movieSeasonLetter = movieMatch.Groups[2].Value;
                        string movieSeasonNumber = movieMatch.Groups[3].Value;
                        string movieEpisodeLetter = movieMatch.Groups[4].Value;
                        string movieEpisodeNumber = movieMatch.Groups[5].Value;
                        string movieEndName = movieMatch.Groups[6].Value;

                        foreach (FileInfo anotherFile in files)
                        {
                            string anotherFileName = anotherFile.Name;
                            Match subtitleMatch = Regex.Match(anotherFileName, subtitlePattern, RegexOptions.IgnoreCase);

                            if (subtitleMatch.Success)
                            {
                                string subtitleEpisodeNumber = subtitleMatch.Groups[5].Value;

                                if (movieEpisodeNumber == subtitleEpisodeNumber)
                                {
                                    string newPath = i_Directory + "\\" + movieStartName + movieSeasonLetter + movieSeasonNumber + movieEpisodeLetter + subtitleEpisodeNumber + movieEndName + ".srt";
                                    File.Move(anotherFile.FullName, newPath);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            MessageBox.Show("done");
        }


        public static void ShiftSubtitlesFiles(string i_Directory, int i_Hour, int i_Minutes, int i_Secnods, int i_MiliSeconds, bool i_AddTime)
        {
            DirectoryInfo directory = new DirectoryInfo(i_Directory);
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                string nameFile = file.Name;
                Match mkvMatch = Regex.Match(nameFile, srtPattern, RegexOptions.IgnoreCase);

                if (mkvMatch.Success)
                {
                    ShiftSubtitlesFile(file, i_Hour, i_Minutes, i_Secnods, i_MiliSeconds, i_AddTime);
                    // call to copy file and change the time
                    // we create new file with the correct time
                    // delete the old file and change the name of the new file to the old file's name
                    // or create new directory and put the new files at this directory

                }
            }

            MessageBox.Show("done");
        }


        private static void ShiftSubtitlesFile(FileInfo i_SourceFile, int i_Hour, int i_Minutes, int i_Secnods, int i_MiliSeconds, bool i_AddTime)
        {
            StreamReader sourceFile = new StreamReader(i_SourceFile.FullName, System.Text.ASCIIEncoding.Default);


            //StreamReader sourceFile = new StreamReader(i_SourceFile.FullName, System.Text.UTF8Encoding.UTF8);
            StreamWriter targetFile = new StreamWriter(i_SourceFile.Directory + "\\new" + i_SourceFile.Name);
            string CurrentLine;

            while ((CurrentLine = sourceFile.ReadLine()) != null)
            {
                targetFile.WriteLine(TimeChange.change(CurrentLine, i_Hour, i_Minutes, i_Secnods, i_MiliSeconds, i_AddTime));
            }

            sourceFile.Close();
            targetFile.Close();
        }

        private static string pattern = @"(\w\w):(\w\w):(\w\w),(\w\w\w) --> (\w\w):(\w\w):(\w\w),(\w\w\w)";

        public static void CopySubtitlesTimeToOtherFiles(string I_Directory, string i_EditFileName, string I_SourceFileName)
        {
            //StreamReader sourceFile = new StreamReader(i_SourceFile.FullName, System.Text.ASCIIEncoding.Default);
            ////StreamReader sourceFile = new StreamReader(i_SourceFile.FullName, System.Text.UTF8Encoding.UTF8);
            //StreamWriter targetFile = new StreamWriter(i_SourceFile.Directory + "\\new" + i_SourceFile.Name);



            StreamReader editFile = new StreamReader(I_Directory + "\\" + i_EditFileName, System.Text.ASCIIEncoding.Default);
            StreamReader sourceFile = new StreamReader(I_Directory + "\\" + I_SourceFileName, System.Text.ASCIIEncoding.Default);
            StreamWriter targetFile = new StreamWriter(I_Directory + "\\new" + I_SourceFileName);

            string EditFileCurrentLine;
            string sourceFileCurrentLine;
            bool editFilewrite = true;

            while ((EditFileCurrentLine = editFile.ReadLine()) != null)
            {
                sourceFileCurrentLine = sourceFile.ReadLine();

                if (editFilewrite)
                {
                    Match match = Regex.Match(EditFileCurrentLine, pattern, RegexOptions.IgnoreCase);

                    if (!match.Success)
                    {
                        targetFile.WriteLine(EditFileCurrentLine);
                    }
                    else
                    {
                        editFilewrite = false;
                    }
                }

                if (!editFilewrite)
                {
                    Match match = Regex.Match(EditFileCurrentLine, pattern, RegexOptions.IgnoreCase);

                    if (match.Success)
                    {
                        targetFile.WriteLine(sourceFileCurrentLine);
                    }
                    else
                    {
                        editFilewrite = true;
                    }
                }
            }

            editFile.Close();
            sourceFile.Close();
            targetFile.Close();
        }
    }
}
