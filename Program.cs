using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.正则表达式中使用引用达到，匹配出局部内容加前缀如这里给src中的图片地址加上域名
            string testHtml = "<img src=\"meinv01.gif\" /><img src=\"meinv02.gif\" /><img src=\"meinv03.gif\" />";
            string result = Regex.Replace(testHtml, @"(<img src="")(.+?)("" />)", "$1http://www.baidu.com/$2$3");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
