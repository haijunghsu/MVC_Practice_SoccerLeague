/* Team 1-3 
 * Members: HaiJung Hsu, Bailey Colemen, Ethan Guinn, and Tiara Johnson
 * Section 1
 * Project Description: This program uploads a webpage that contains the MLS Soccer League rankings based on their wins.
 */
using SoccerLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerLeague.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index() //actionResult is the return type, and Index is a method
        {
            //declare variables
            List<SoccerTeam> lstTeams = new List<SoccerTeam>();
            List<SoccerTeam> lstSorted;

            int iTeamRank = 0;
      
            //Load the data
            lstTeams.Add(new SoccerTeam("RSL", 35));
            lstTeams.Add(new SoccerTeam("Colorado", 24));
            lstTeams.Add(new SoccerTeam("FC Dallas", 42));
            lstTeams.Add(new SoccerTeam("Sporting KC", 39));
            lstTeams.Add(new SoccerTeam("San Jose", 16));
            lstTeams.Add(new SoccerTeam("Houston", 27));
            lstTeams.Add(new SoccerTeam("Seattle", 32));
            lstTeams.Add(new SoccerTeam("Vancouver", 33));
            lstTeams.Add(new SoccerTeam("Minnesota", 29));
            lstTeams.Add(new SoccerTeam("Portland", 37));
            lstTeams.Add(new SoccerTeam("LA Galaxy", 37));
            lstTeams.Add(new SoccerTeam("LAFC", 39));

            //Sort the list
            lstSorted = lstTeams.OrderByDescending(x => x.points).ToList();

            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Ranking</th>";
            ViewBag.Output += "<th>Logo</th>";
            ViewBag.Output += "<th>Team Name</th>";
            ViewBag.Output += "<th>Points</th>";
            ViewBag.Output += "</tr>";

            foreach (SoccerTeam myObj in lstSorted)
            {
                iTeamRank++;
                //calling imageAppear and disappear function corresponsed to the detection of the hovering mouse pointer
                ViewBag.Output += "<tr onmouseover = \"imageAppear(\'" + myObj.name + "\')\" onmouseout = \"imageDisappear(\'" + myObj.name + "\')\" >";
                ViewBag.Output += "<td>" + iTeamRank + "</td>";
                //creating new column to display team logo for each team
                ViewBag.Output += "<td>" + "<img src =\"/Content/Images/" + myObj.name + "_Logo.png\" alt=\"logo\" width=\"50\" height=\"50\"></img></td>";
                ViewBag.Output += "<td>" + myObj.name + "</td>";
                //loading images after the score and hidden from displaying
                ViewBag.Output += "<td>" + myObj.points + "<img src =\"/Content/Images/" + myObj.name + "_pic.jpg\" width=\"1000\" height=\"700\" id =\"" 
                    + myObj.name + "\" style =\"position: absolute; visibility: hidden;\"/>" + "</td>";
                ViewBag.Output += "</tr>";
            }

            ViewBag.Output += "</table>";

            return View();
        }
    }
}