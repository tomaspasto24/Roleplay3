using Library;

namespace Library
{
    public class Enemy : Character
    {
        protected int victoryPoints {get; set;}

        public int ReturnVictoryPoints()
        {
            return this.victoryPoints;
        }
    }
}
