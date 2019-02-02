using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    //public DeployEnemy deploy;
   void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.tag != "Enemy")
        {
            if (collision.gameObject.tag == "Enemy")
            {
            /* if (deploy.enemyHealth >= 2)
             {
                 deploy.enemyHealth =-deploy.damage;
                 if (deploy.enemyHealth <= 0)
                 {*/
            Destroy(collision.gameObject);

            }  
        }
        
            
        
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
    }
}
