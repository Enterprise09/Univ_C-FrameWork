﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat_B
{
    class Cat
    {
        public string Name;
        public int Age;
        private int Happiness;      //행복 지수 : 0 ~ 100 사이의 값

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void GetBoared()
        {
            Happiness = Happiness - 10;
            if(Happiness < 0)
            {
                Happiness = 0;
            }
        }

        public void Play()
        {
            Happiness = Happiness + 10;
            if(Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public void Eat()
        {
            Happiness = Happiness + 20;
            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public string Express()
        {
            string message = "";
            if(Happiness >= 80)
            {
                message = "I'm very Happy~ ";
            }else if(Happiness >= 60)
            {
                message = "I'm Happy~ ";
            }
            else if (Happiness >= 40)
            {
                message = "I'm soso~ ";
            }
            else if (Happiness >= 20)
            {
                message = "I'm gloomy~ ";
            }
            else
            {
                message = "I', sad ~";
            }

            return this.Name + " : " + message;
        }

    }
}
