using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MainClass
    {
        public static void CreateFile()    
        {
            string path1 = "/Users/ilias/Desktop/start";  //первый путь это папка где мы создаем файл
            string fileName = "NewFile.txt";          // пишем имя файла
            path1 = System.IO.Path.Combine(path1, fileName);   // создаем файл в первой папке     
            System.IO.File.WriteAllText(path1, "Ilyas Shadman");    //пишем что-нибудь в файле 
            string path2 = "/Users/ilias/Desktop/finish";     // второй путь,где мы сохраняем первый файл
            string newFile = System.IO.Path.Combine(path2, fileName);  //  создаем второй файл к второй папке
            System.IO.File.Copy(path1, newFile, true);     //копируем первый файл к второй
            DeletFile(path1);        //вызываем DeletFile
        }
        public static void DeletFile(string path)
        {
            if (File.Exists(path))
            {     //задаем команду,если файл существует тогда мы удаляем его
                File.Delete(path);
            }
        }
        public static void Main(string[] args)
        {
            CreateFile();       //вызываем CreateFile
        }
    }
}