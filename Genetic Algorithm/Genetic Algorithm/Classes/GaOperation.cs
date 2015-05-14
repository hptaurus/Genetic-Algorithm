using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genetic_Algorithm.Interfaces;

namespace Genetic_Algorithm.Classes
{
    public class GaOperation : IGeneticAlgorithm
    {
        #region Fields
        public Population population;

        #endregion

        #region Constructors
        public GaOperation()
        {
            this.population = new Population();
        }
        #endregion

        #region Private Methods
        
        #endregion

        #region Public Methods
        //Selection
        public Chromosome Selection()
        {
            return null;
        }


        //Crossover
        public Chromosome PMXCrossOver(Chromosome parent1, Chromosome parent2)
        {
            return null;
        }


        //Mutation
        public Chromosome Mutation(Chromosome solution)
        {
            return null;
        }
        public void Run()
        {

        }
        #endregion

        #region Events
        #endregion

    }
}
