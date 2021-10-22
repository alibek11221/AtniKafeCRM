using System;
using AntiKafeCRM.Processors;

namespace AntiKafeCRM
{
    class Program
    {

        
        static void Main(string[] args)
        {
            // Создаем объект процессора
            ClientProcessor processor = new ClientProcessor();
            
            while (true)
            {
                selectOperation(processor);
            }
        }

        static void selectOperation(ClientProcessor processor)
        {
            // Вывод строк на экран
            Console.WriteLine("Выберите операцию :");
            Console.WriteLine("1 - вывести список клиентов");
            Console.WriteLine("2 - добавить нового клиента");
            // Сохраняем введенное пользователем число
            int operation = int.Parse(Console.ReadLine());
            

            // Если выбрана операция вывод
            if (operation == 1)
            {
                // вызываем метод отрисовки списка клиентов
                processor.ListClients();
            }
            // Иначе если операция добавить
            else if (operation == 2)
            {
                // вызваем метод добавления нового пользоватлея
                processor.AddClient();
            }
            // иначе
            else
            {
                // Выводим сообщение об ошибке
                Console.WriteLine("Операция не найдена");
            }
        }
    }
}