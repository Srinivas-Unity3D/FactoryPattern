using UnityEngine;
using WithoutFactory.Enemies;
using WithoutFactory.Interfaces;

namespace WithoutFactory 
{
    public class EnemySpawner : MonoBehaviour
    {
        void Start()
        {
            IEnemy zombie = new Zombie();
            IEnemy robot = new Robot();

            zombie.Attack();
            robot.Attack();
        }
    }

}
