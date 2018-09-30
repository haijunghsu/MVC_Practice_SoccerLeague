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
    public class Team
    {
        public string name { get; set; }
        public int wins { get; set; }    
        public int loss { get; set; }
    }
}