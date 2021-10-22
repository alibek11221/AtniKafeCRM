using System;
using System.Collections.Generic;
using AntiKafeCRM.Models;

namespace AntiKafeCRM.Processors
{
    public class ClientProcessor
    {
        // массив возможных тарифов
        public string[] tariffs = { "30 минут", "1 час", "2 часа", "5 часов" };

        // список клиентов List<> - будет рассказано на лекциях
        private List<Client> _clients = new List<Client>();

        // Метод установки времени окончания в зависимости от выбранного тарифа
        private void setUpEndTime(Client client)
        {
            switch (client.Tariff)
            {
                case "30 минут":
                    client.EndTime = client.BeginTime.AddMinutes(30);
                    break;
                case "1 час":
                    client.EndTime = client.BeginTime.AddHours(1);
                    break;
                case "2 часа":
                    client.EndTime = client.BeginTime.AddHours(2);
                    break;
                case "5 часов":
                    client.EndTime = client.BeginTime.AddHours(5);
                    break;
            }
        }

        // Метод создания нового клиента
        public void AddClient()
        {
            Console.WriteLine("Введите название клиента :");
            string alias = Console.ReadLine();
            Console.WriteLine("Выберите тариф :");
            for (int i = 0; i < tariffs.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {tariffs[i]}");
            }

            int tariffIndex = int.Parse(Console.ReadLine());
            string tariff = tariffs[tariffIndex - 1];

            Client client = new Client(alias, DateTime.Now, tariff);

            setUpEndTime(client);

            _clients.Add(client);
        }

        //Метод вывода клиентов
        public void ListClients()
        {
            if (_clients.Count == 0)
            {
                Console.WriteLine("Клиентов пока нет");
            }
            else
            {
                foreach (Client client in _clients)
                {
                    Console.WriteLine($"id: {client.Id}, псевдоним: ${client.Alias}, тарифф {client.Tariff}");
                    Console.WriteLine($"время начала {client.BeginTime} - время окончания {client.EndTime}");
                }
            }
        }
    }
}