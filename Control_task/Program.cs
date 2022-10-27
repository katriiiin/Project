using System;
using System.Xml;

namespace Control_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Чтение XML-файла и его вывод на экран
            XmlDocument xml = new XmlDocument();
            xml.Load("INPUT.xml");
            XmlElement element = xml.DocumentElement;//Получаем корневой элемент
            foreach (XmlNode xnode in element)//Пробегаемся по всем дочерним узлам
            {
                if(xnode.Attributes.Count>0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                foreach (XmlNode childnode in xnode.ChildNodes)//Коллекция дочерних узлов 
                {
                    if (childnode.Name== "nickname")
                        Console.WriteLine($"Кличка:{ childnode.InnerText} ");
                    if (childnode.Name == "age")
                        Console.WriteLine($"Возраст:{ childnode.InnerText} ");
                    if (childnode.Name == "color")
                        Console.WriteLine($"Цвет:{ childnode.InnerText} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


