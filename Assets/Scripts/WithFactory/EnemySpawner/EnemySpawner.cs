using UnityEngine;
using WithFactory.Interfaces;
using WithFactory.Factory;


namespace WithFactory 
{
    public class EnemySpawner : MonoBehaviour
    {
        void Start()
        {
            IEnemy zombie = EnemyFactory.CreateEnemy("Zombie");
            IEnemy robot = EnemyFactory.CreateEnemy("robot");
            IEnemy hydra = EnemyFactory.CreateEnemy("Hydra");

            zombie?.Attack();
            robot?.Attack();
            hydra?.Attack();
        }

        
    }
}

