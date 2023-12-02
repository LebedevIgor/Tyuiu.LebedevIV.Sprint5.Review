using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;

namespace Tyuiu.LebedevIV.Sprint5.TaskReview.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint5.Review\Tyuiu.LebedevIV.Sprint5.TaskReview.V19\bin\Debug\OutPutDataFileTask7V19.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }


            string fileContent = File.ReadAllText(path);

            string modifiedContent = Regex.Replace(fileContent, @"(?i)сс", "с");

            File.WriteAllText(pathSaveFile, modifiedContent);
            return pathSaveFile;
        }
    }
}
