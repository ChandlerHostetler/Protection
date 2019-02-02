using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEnemyMovement : MonoBehaviour
{
    public int enemySpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * enemySpeed);
    }
}