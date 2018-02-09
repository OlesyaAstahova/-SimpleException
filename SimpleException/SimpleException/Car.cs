using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        //Константа для представления макс скорости
        public const int MaxSpeed = 100;

        //Свойства автомобиля
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        //Проверка вышел ли из строя автомобиль
        private bool carIsDead;

        //Автомобиль имеет радиоприемник
        private Radio theMusicBox = new Radio();

        //Конструкторы
        public Car() { }
        public Car (string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes (bool state)
        {
            //Делегировать запрос внутреннему объекту 
            theMusicBox.TurnOn(state);
        }
        //Проверить, не перегрелся ли автомобиль (должно генерироваться исключение)
        public void Accelerate (int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if ( CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                   // Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    //carIsDead = true;
                    // Использовать ключевое слово throw для генерации исключения
                    throw new Exception(string.Format("{0} has overheated!", PetName));
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
