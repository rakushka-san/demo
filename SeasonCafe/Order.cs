using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonCafe
{
    internal class Order
    {
        public int id { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string table { get; set; }
        public int clientsAmount { get; set; }
        public string order {  get; set; }
        public string status { get; set; }

        public Order(int id, string table, int clientsAmount, string order, string status)
        {
            this.id = id;
            this.table = table;
            this.clientsAmount = clientsAmount;
            this.order = order;
            this.status = status;
        }

        public Order(string table, int clientsAmount, string order, string status)
        {
            this.table = table;
            this.clientsAmount = clientsAmount;
            this.order = order;
            this.status = status;
        }

        public Order(int id, string table, int clientsAmount, string order, string status, string date, string time)
        {
            this.id = id;
            this.table = table;
            this.clientsAmount = clientsAmount; 
            this.order = order;
            this.status = status;
            this.date = date;
            this.time = time;
        }

        public Order(string table, int clientsAmount, string order, string status, string date, string time)
        {
            this.table = table;
            this.clientsAmount = clientsAmount;
            this.order = order;
            this.status = status;
            this.date = date;
            this.time = time;
        }
    }
}
