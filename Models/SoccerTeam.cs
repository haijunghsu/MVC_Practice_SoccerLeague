/* Team 1-3 
 * Members: HaiJung Hsu, Bailey Colemen, Ethan Guinn, and Tiara Johnson
 * Section 1
 * Project Description: This program uploads a webpage that contains the MLS Soccer League rankings based on their wins.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace SoccerLeague.Models
{
    public class SoccerTeam : Team
    {
        //Empty constructor
        public SoccerTeam()
        {
        }
        //constructor with name and points
        public SoccerTeam(string teamName, int teamPoints)
        {
            base.name = teamName;
            this.points = teamPoints;
        }
        public int draw { get; set; } //Attributes
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int differential { get; set; }
        public int points { get; set; }
    }
}