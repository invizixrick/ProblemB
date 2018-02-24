using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, Team> Teams = new Dictionary<string, Team>();
                InitTeams(Teams);
                Team team;

                while (true)
                {
                    Console.Write("Enter Team Name > ");
                    string desiredTeam = Console.ReadLine();
                    if (desiredTeam.Contains("quit") || desiredTeam.Contains("exit")) break;
                    Teams.TryGetValue(desiredTeam.ToUpper(), out team);
                    Console.WriteLine(team != null ? team.Mascot : "Unknown team name");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error getting mascot...exiting!");
            }


        }
        static void InitTeams(Dictionary<string, Team> teams)
        {
            Team team = new Team("Arizona Cardinals", "Big Red");
            teams.Add(team.Name, team);
            team = new Team("Atlanta Falcons", "Freddie Falcon");
            teams.Add(team.Name, team);
            team = new Team("Carolina Panthers", "Sir Purr");
            teams.Add(team.Name, team);
            team = new Team("Chicago Bears", "Staley Da Bear");
            teams.Add(team.Name, team);
            team = new Team("Dallas Cowboys", "Freddie Falcon");
            teams.Add(team.Name, team);
            team = new Team("Detroit Lions", "Roary");
            teams.Add(team.Name, team);
            team = new Team("Green Bay Packers", "None");
            teams.Add(team.Name, team);
            team = new Team("Minnesota Vikings", "Ragnar, Viktor");
            teams.Add(team.Name, team);
            team = new Team("New Orleans Saints", "Gumbo, Sir Saint");
            teams.Add(team.Name, team);
            team = new Team("New York Giants", "None");
            teams.Add(team.Name, team);
            team = new Team("Philadelphia Eagles", "Swoop, Air Swoop");
            teams.Add(team.Name, team);
            team = new Team("Los Angeles Rams", "Rampage");
            teams.Add(team.Name, team);
            team = new Team("San Francisco 49ers", "Sourdough Sam");
            teams.Add(team.Name, team);
            team = new Team("Seattle Seahawks", "Blitz; Boom; Taima");
            teams.Add(team.Name, team);
            team = new Team("Tampa Bay Buccaneers", "Captain Fear");
            teams.Add(team.Name, team);
            team = new Team("Washington Redskins", "None");
            teams.Add(team.Name, team);

            //only modification to existing code for Deliverable 2
            InitAFCTeams(teams);

        }

        //Add for Deliverable 2
        static void InitAFCTeams(Dictionary<string, Team> teams)
        {
            Team team = new Team("Buffalo Bills", "Billy Buffalo");
            teams.Add(team.Name, team);
            team = new Team("Miami Dolphins", "T.D.");
            teams.Add(team.Name, team);
            team = new Team("New England Patriots", "Pat Patriot");
            teams.Add(team.Name, team);
            team = new Team("New York Jets", "None");
            teams.Add(team.Name, team);
            team = new Team("Baltimore Ravens", "Poe, Rise and Conquer");
            teams.Add(team.Name, team);
            team = new Team("Cincinnati Bengals", "Who Dey");
            teams.Add(team.Name, team);
            team = new Team("Cleveland Browns", "Chomps, Swagger, Brownie the Elf");
            teams.Add(team.Name, team);
            team = new Team("Pittsburgh Steelers", "Steely McBeam");
            teams.Add(team.Name, team);
            team = new Team("Houston Texans", "Toro");
            teams.Add(team.Name, team);
            team = new Team("Indianapolis Colts", "Blue");
            teams.Add(team.Name, team);
            team = new Team("Jacksonville Jaguars", "Jaxson de Ville");
            teams.Add(team.Name, team);
            team = new Team("Tennessee Titans", "T-Rac");
            teams.Add(team.Name, team);
            team = new Team("Denver Broncos", "Miles, Thunder II");
            teams.Add(team.Name, team);
            team = new Team("Kansas City Chiefs", "K. C. Wolf; Warpaint");
            teams.Add(team.Name, team);
            team = new Team("Los Angeles Chargers", "Boltman");
            teams.Add(team.Name, team);
            team = new Team("Oakland Raiders", "Raider Rusher");
            teams.Add(team.Name, team);


        }

    }

    public class Team
    {
        string name;
        string mascot;
        public Team(string teamName, string teamMascot)
        {
            this.name = teamName.ToUpper();
            this.mascot = teamMascot;
        }
        public string Name { get { return this.name; } }
        public string Mascot { get { return this.mascot; } }
    }
}
