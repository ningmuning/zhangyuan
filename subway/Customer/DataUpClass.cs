using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subway.Customer
{
    class DataUpClass
    {
        private string YongHuMing;
        private string issingle;
        private string start;
        private string end;
        private int price;
        private int num;
        private int allprice;
        private string Password;
        public DataUpClass(Ticket t, string yonghuming,string issingle, string start, string end, int price,int num,string password)
        {
            this.YongHuMing = yonghuming;
            this.issingle = issingle;
            this.start = start;
            this.end = end;
            this.price = price;
            this.num = num;
            this.Password = password;
            t.YongHuMing = this.YongHuMing;
            t.Issigle = issingle;
            t.StartP = start;
            t.Time = DateTime.Now;
            t.Cost = price;
            t.Num = num;
            t.Destination = end;
            using (var context=new MyDbEntities2())
            {
                var q = from tt in context.Ticket
                        where tt.YongHuMing == this.YongHuMing && tt.Password == this.Password
                        select tt;
                if (q.Count() == 1)
                {
                    foreach(var v in q)
                    {
                        v.Issigle = this.issingle;
                        v.Num = this.num;
                        v.Time = DateTime.Now;
                        v.Destination = this.end;
                        v.StartP = this.start;
                        v.Cost = this.price;
                    }
                }
                context.SaveChanges();              
            }
        }
    }
}
