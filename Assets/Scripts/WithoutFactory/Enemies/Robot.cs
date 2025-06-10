using UnityEngine;
using WithoutFactory.Interfaces;


namespace WithoutFactory.Enemies 
{
    public class Robot : IEnemy
    {
        public void Attack()
        {
            Debug.Log("Robot Shooting!");
        }
    }

}
