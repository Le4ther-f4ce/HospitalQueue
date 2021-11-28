using System;

namespace Hospital_queue
{
    class Program
    {   
        static void Main(string[] args)
        {
            int timeOfReceipt = 10; //minutes
            int minutesPerHour = 60;

            Console.Write("Введите количество людей стоящих в очереди: ");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            int totalWaitingTime = numberOfPeople * timeOfReceipt;
            Console.WriteLine($"Время ожидания составит: " +
                $"{totalWaitingTime / minutesPerHour} часов" +
                $" {totalWaitingTime % minutesPerHour} минут");
        }
    }
}
