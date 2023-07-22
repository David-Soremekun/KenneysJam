using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public List<GameObject> enemyList;
    public int enemyLimit = 20;
    private int currentEnemyCount = 0;

    public GameObject ePrefab;

    public Rect SpawnArea;
    // Update is called once per frame
    void Update()
    {
        // do we have enough enemies
        if (currentEnemyCount < enemyLimit)
        {
            // no, no we do not! so create one.
            Vector3 spawnLocation = new Vector3(
                Random.Range(SpawnArea.x, SpawnArea.y),         // x position
                Random.Range(SpawnArea.width, SpawnArea.height),// y position
                0);                                             // z position 

            GameObject go = Instantiate(ePrefab, spawnLocation, Quaternion.identity);
            enemyList.Add(go);
            currentEnemyCount += 1; // we made one, so note it down in our var
        }
    }

    
    public void enemyDied()
    {
        currentEnemyCount--;
    }


}
