using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm.Classes
{
    public class Population
    {
        #region Fields
        public int _averageFitness, _chromosomeLength, _maximumFitness, _minimumFitness;
        private List<Chromosome> _solutions;

        public List<Chromosome> Solutions
        {
            get { return this._solutions; }
            set { this._solutions = value; }
        }
        #endregion

        #region Constructors
        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        #endregion

        #region Events
        #endregion

    }
}
