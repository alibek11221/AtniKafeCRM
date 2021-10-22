using System;

namespace AntiKafeCRM.Models
{
    public class Client
    {
        public Guid Id;
        public string Alias;
        public DateTime BeginTime;
        public DateTime EndTime;
        public string Tariff;

        public Client()
        {
            Id = Guid.NewGuid();
        }
        
        public Client(string alias, DateTime beginTime, string tariff) : this()
        {
            Alias = alias;
            BeginTime = beginTime;
            Tariff = tariff;
        }

      
    }
}