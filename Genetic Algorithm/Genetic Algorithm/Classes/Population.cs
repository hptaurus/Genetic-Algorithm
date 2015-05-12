using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genetic_Algorithm.Interfaces;

namespace Genetic_Algorithm.Classes
{
    public class Population : IGeneticAlgorithm
    {
        #region Fields
        private int _averageFitness, _maximumFitness, _minimumFitness;
        private List<Chromosome> _solutions;

        public int AverageFitness
        {
            get { return this._averageFitness; }
        }
        public int MaximumFitness
        {
            get { return this._maximumFitness; }
        }
        public int MinimumFitness
        {
            get { return this._minimumFitness; }
        }
        public List<Chromosome> Solutions
        {
            get { return this._solutions; }
            set 
            {
                this._solutions = value;
            }
        }
        #endregion

        #region Constructors
        public Population()
        {
            
        }
        #endregion

        #region Private Methods
        private int CalcAvrgFitness()
        {
            
            return 0;
        }
        private int CalcMaxFitness()
        {
            return 0;
        }
        private int CalcMinFitness()
        {
            return 0;
        }
        private List<List<int>> DgvtoList()
        {
            return null;
        }
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
