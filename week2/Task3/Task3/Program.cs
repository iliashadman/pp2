using System;
using System.IO;
namespace task3
{
    class MainClass
    {
        public static void Mn(int level)             // разделяем по уровням линий
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
        }
        public static void Direc(DirectoryInfo dir, int level)        //выводим имя и директорию 
        {
            foreach (FileInfo f in dir.GetFiles())      //берем файл из директории и показываем
            {
                Mn(level);
                Console.WriteLine(f.Name);
            
            }
            foreach (DirectoryInfo d in dir.GetDirectories())  //из директорий берем директорий и показываем
            {
                Mn(level);
                Console.WriteLine(d.Name);
                Console.ReadKey();
                Direc(d, level + 1);//вызываем Direc и показываем другие файлы и директории  
                                       
            }
        }

        public static void Main(string[] args)
        {
            string path = Console.ReadLine();   //ввыводим в консоле наш путь
            DirectoryInfo dirr = new DirectoryInfo(path);    // берем информацию о директории из string path
            Direc(dirr, 0);     //вызываем Direc, dir - информация о директории , 0 - первый уровень
            
        }
    }
}