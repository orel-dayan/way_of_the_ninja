using UnityEngine;
/*
`* This component represents an event that is triggered when all enemies are killed.
*/

public class KillAllEnemiesEvent : Event
{
    [SerializeField] Enemy[] enemies;
   
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (!enemies[i].getIsEnemyKilled())
            {
                return;
            }
        }
       // Debug.Log("killAllEnemies Event is finished");
        IsFinished();
    }
}
