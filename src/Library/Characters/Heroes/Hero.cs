using System;

namespace Library
{
    public class Hero : Character
    {
        protected int victoryPointsCounter {get; set;}

        public void AddVictoryPoints(int vp)
        {
            this.victoryPointsCounter += vp;
        }
        public int ReturnVictoryPoints()
        {
            return this.victoryPointsCounter;
        }
        public void ResetVictoryPoints()
        {
            this.victoryPointsCounter = 0;
        }
    }
}