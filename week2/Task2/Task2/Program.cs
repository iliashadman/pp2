using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;

            s = File.ReadAllText("C:/Users/ilias/Desktop/pp2/week2/Task2/input.txt");//пишем полный путь файла с которого нужно считать
        
            
            string[] arrayS = s.Split(' ');// создаем стринг и указываем что на место пробела нужно делать сплит

            int[] num = new int[arrayS.Length];//создаем массив который равен стрингу

            string output = "";//создаем стринг чтобы сохранять в него прайм намберс

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(arrayS[i]);//каждый стринг превращаем в интайджер
            }

         
            for (int k = 0; k < num.Length; k++)//создаем цикл который пробегается по всем цифрам
            {
                for (int i = 2; i < num[k]; i++) //берем каждую цифру и делим от 2
                {
                    if ((num[k] % i) == 0)//если цифр делится без остатка тогда цикл прервется и массив будет считать новую цифру 
                    {
                        break;
                    }

                    if(i+1 == num[k])// или если цифр будет делить себя до конца тогда он будет сохраняться
                    {
                        output = output + num[k].ToString()+ " ";//сохраняем все в output
                      
                    }
                }
            }

            

            File.WriteAllText("C:/Users/ilias/Desktop/pp2/week2/Task2/output.txt", output);//выводим ответ в новый файл 
           // Console.WriteLine(s);
          //  Console.ReadKey();
        }
    }
}
