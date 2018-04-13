using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace subway.EnterAndLeave
{
    
    class MyClass
    {
        static int cou = 1;
        public static string[] place = { "博学路", "郑州东站", "东风南路", "农业南路", "黄河南路", "会展中心",
        "民航路","燕庄","紫荆山","人民路","二七广场","郑州火车站","医学院","绿城广场","碧沙岗","桐柏路"
        ,"秦林路","西三环","西流湖"};
        public static int[] pri = { 2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6};

        public static List<MyTicket> tickets = new List<MyTicket>();
        public static void my(String str,int pri,int isUse)
        {

            tickets.Add(new MyTicket {Number = cou, Start = "市体育中心", End = str, Price = pri, isUseful = isUse});
            //MessageBox.Show(client.Number + " "+client.Time+" "+client.Destination+" "+client.Price+" "+client.IsUseful);
                
            cou++;
        }
    }
    public class MyTicket
    {
        public int Number { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int Price { get; set; }
        public int isUseful { get; set; }
    }
}
