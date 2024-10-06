using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    internal class VotingSystem
    {
        public int voteCount;
        public VoteOption[] votes;

        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
            voteCount = 0;
        }

        public void CastVote(VoteOption vote)
        {
            votes[voteCount] = vote;
            voteCount++;
            Console.WriteLine($"Vote casted: {vote}");
        }

        public void DisplayResults()
        {
            int yesVotes = 0;
            int noVotes = 0;

            foreach (var vote in votes)
            {
                if (vote == VoteOption.Yes) 
                    yesVotes++;
                else if (vote == VoteOption.No)
                    noVotes++;
            }

            Console.WriteLine($"\nResults:\nYes: {yesVotes}\nNo: {noVotes}");
        }


    }
}
