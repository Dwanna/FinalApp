using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Team
{
    private int games_played;
    private int points;
    private string name;
    public Team(string name, int games, int points)
    {
        this.games_played = games;
        this.points = points;
        this.name = name;
    }
    

  public void win()
    {
        this.points += 3;
        games_played++;
    }
    public void loss()
    {
        this.games_played++;
    }
    public void draw()
    {
        this.games_played++;
        this.points += 1;
    }
    public void printDetails()
    {
        Console.WriteLine("Total amount of gamesPlayed is"+this.games_played );
    }

   public int readGamesPlayed()
    {
        return this.games_played;
    }
    public int readPoints()
    {
        return this.points;
    }
    public string readName()
    {
        return this.name;
    }




       
}

