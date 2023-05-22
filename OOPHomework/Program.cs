using System;

namespace OOPHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating players
            FootballPlayer player1 = new Goalkeeper("John", 1, 25, 180);
            FootballPlayer player2 = new Defender("Mike", 5, 28, 185);
            FootballPlayer player3 = new Midfield("David", 10, 30, 175);
            FootballPlayer player4 = new Striker("Chris", 9, 27, 182);
            FootballPlayer player5 = new Midfield("George", 2, 35, 170);
            FootballPlayer player6 = new Defender("Ivan", 4, 77, 200);

            // Creating coach
            Coach coach = new Coach("Alex", 45);

            // Creating team
            Team team = new Team();
            team.Coach = coach;
            team.Players = new FootballPlayer[] { player1, player2, player3, player4 };
            double averageAge = team.CalculateAverageAge();

            // Creating referee
            Referee referee = new Referee("Mark", 40);

            // Creating game
            Game game = new Game();
            game.Team1 = team;
            game.Referee = referee;
        }
    }
}
