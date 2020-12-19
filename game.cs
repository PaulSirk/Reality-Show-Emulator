using System;
using System.Collections.Generic;
using System.Linq;
using people;

namespace game
{
    public class game
    {
        public List<people.people> contestants = new List<people.people>();
        public List<people.people> eliminationList = new List<people.people>();

        public void createObject(string firstName = "", string lastName = "", int id = -1)
        {
            people.people member = new people.people(firstName, lastName, id);
            contestants.Add(member);
        }

        private void addToEliminationList(people.people eliminate)
        {
            eliminate.setPlacement(contestants.Count());
            eliminationList.Add(eliminate);
        }

        public void eliminateContestant(int contestId)
        {
            var found = contestants.SingleOrDefault(r => r.getId() == contestId);
            if (found != null)
            {
                contestants.Remove(found);
                addToEliminationList(found);
            }
        }

        public string outputWinner()
        {
            people.people winner = contestants[0];
            return "Congratulations " + winner.getFullName() + "!";
        }
    }
}