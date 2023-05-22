using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPHomework
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
    }

    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int number, int age, double height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }

    public class Defender : FootballPlayer
    {
        public Defender(string name, int number, int age, double height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }

    public class Midfield : FootballPlayer
    {
        public Midfield(string name, int number, int age, double height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }

    public class Striker : FootballPlayer
    {
        public Striker(string name, int number, int age, double height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }

    public class Coach : Person
    {
        public Coach(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Referee : Person
    {
        public Referee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Team
    {
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }

        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Length;
        }
    }

    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Person[] AssistantReferees { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public void PrintResult()
        {
            Console.WriteLine("Game Result: " + Result);
        }
    }
}

    

