using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCode.AspNetCore.HtmlAgilityPack.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // HtmlDocument document = new HtmlDocument();
            // string str = @"<div><span>ddd</span></div>";
            // document.LoadHtml(str);

            //var list = document.DocumentNode.SelectNodes("div");

            // foreach (var item in list)
            // {
            //     var _list = item.SelectNodes("span");
            //     foreach (var _item in _list)
            //     {
            //         Console.WriteLine(_item.InnerText);
            //     }
            // }
            string str = "<div>asdasd</div><script>alert('hello')</script>";
            str = HtmlFilter.Instance.SanitizeHtml(str);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
