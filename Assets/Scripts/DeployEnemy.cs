using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployEnemy : MonoBehaviour
{

    float result;
    public GameObject enemy;
    private List<GameObject> enemies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        result = UnityEngine.Random.Range(1, 10);
        
        StartCoroutine(enemySpawn());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator enemySpawn() {
       
        yield return new WaitForSeconds(result);
        if (Time.timeSinceLevelLoad > 10)
        {
            
            result = UnityEngine.Random.Range(1, 5);
        }
        if (Time.timeSinceLevelLoad >= 20) {
            
            result = UnityEngine.Random.Range(1, 3);
        }
        if (Time.timeSinceLevelLoad >= 40) {
            result = 0.1f;
        }
        GameObject enemyPrefab = (GameObject)Instantiate(enemy, transform.position, Quaternion.identity);
        enemies.Add(enemyPrefab);
        

        StartCoroutine(enemySpawn());

    }
   
}
