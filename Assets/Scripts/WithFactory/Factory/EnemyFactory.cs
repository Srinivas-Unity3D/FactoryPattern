using UnityEngine;
using WithFactory.Interfaces;
using WithFactory.Enemies;

namespace WithFactory.Factory 
{
    public static class EnemyFactory 
    {
        public static IEnemy CreateEnemy(string enemyType) 
        {
            switch (enemyType) 
            {
                case "Zombie":
                    return new Zombie();
                case "Robot":
                    return new Robot();
                default:
                    Debug.LogError($"Unknow enemy type: {enemyType}");
                    return null;
            }
        }
    }

}
