using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立xml
            XElement students =new XElement("students",
                new XElement("student",
                    new XElement("name","张三"),
                    new XElement("no","03"),
                    new XElement("tall","175")
                             ),                                       
                 new XElement("student",
                        new XElement("name","李四"),
                        new XElement("no","04"),
                        new XElement("tall","180")
                              )
                                            );
            //增加子级节点
            students.Add(new XElement("student",
                        new XElement("name","王五"),
                        new XElement("no","04"),
                        new XElement("tall","180")
                              )
                          );
            foreach(var v in students.Elements())
            {
                //修改节点
                if(v.Element("name").Value=="李四")
                {
                    v.Element("tall").Value="1米71";
                }
                //删除节点
                if (v.Element("name").Value == "张三")
                {
                    v.Remove();
                }
            }
            Console.WriteLine(students);//打印xml信息到控制台
            XElement doc=XElement.Load(@"..\..\students.xml");//直接读取xml文件内容
            Console.WriteLine(students);//打印xml信息到控制台
            students.Save(@"..\..\students.xml");//储存xml
        }
    }
}
