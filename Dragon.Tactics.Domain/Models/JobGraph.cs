using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Tactics.Domain.Models
{
    public class JobGraph
    {
        // Proposal:
        // - Unit level ups acquire Job Points
        // - Job Points can be used to level a Job
        // - Job Points can also be used to move along the Job Graph and acquire a new job (provided there is a free Job Slot)
        //   - maybe there are stat nodes in the Job Graph that can be picked up in between Job Nodes
        // - Units start with one Job Slot
        // - Units gain a second Job Slot at level X
        // - (maybe) units gain a third Job Slot at max level
        //   - max level should require **significant** investment

    }
}
