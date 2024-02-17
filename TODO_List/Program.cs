using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;
        

    
        
       
        List<string> todoList = new List<string>(); // Создаем список для хранения дел

        while (true)
        {
            Console.WriteLine("Список дел:");
            foreach (string task in todoList)
            {
                 Console.WriteLine("- " + task); // Выводим список задач
            }

                 Console.WriteLine("\nМеню:");
                 Console.WriteLine("1. Добавить задачу");
                 Console.WriteLine("2. Удалить задачу");
                 Console.WriteLine("3. Выход");

                 Console.Write("Выберите действие: ");

            string choice = Console.ReadLine(); // Считываем выбор пользователя

            switch (choice)
            {
            case "1":
                 Console.Write("Введите новую задачу: ");
                        string newTask = Console.ReadLine(); // Считываем новую задачу
                        todoList.Add(newTask); // Добавляем задачу в список
                        break;
            case "2":
            if (todoList.Count == 0)
               {
                 Console.WriteLine("Список дел пуст.");
                        break;
               }
                 Console.Write("Введите номер задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex)) // Считываем номер задачи
               {
                 if (taskIndex >= 1 && taskIndex <= todoList.Count) // Проверяем, что номер в пределах списка
                 {
                      todoList.RemoveAt(taskIndex - 1); // Удаляем задачу по индексу
                 }
                 else
                 {
                  Console.WriteLine("Ошибка: введите корректный номер задачи.");
                 }
               }
            else
               {
                  Console.WriteLine("Ошибка: введите корректный номер задачи.");
               }
                        break;
            case "3":
                  Console.WriteLine("Выход из программы.");
                       return;
            default:
                  Console.WriteLine("Ошибка: введите число от 1 до 3.");
                        break;
            }
        }
        
    }

}
