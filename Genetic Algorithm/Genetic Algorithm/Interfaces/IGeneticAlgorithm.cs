using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genetic_Algorithm.Classes;

namespace Genetic_Algorithm.Interfaces
{
    public interface IGeneticAlgorithm
    {
        Chromosome Selection();
        Chromosome PMXCrossOver(Chromosome parent1, Chromosome parent2);
        Chromosome Mutation(Chromosome solution);
    }
}
