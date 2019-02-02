using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FamilyHealth : MonoBehaviour
{
    public Slider slider;
    public int health;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        damage = 20;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") {
            Destroy(collision.gameObject);
            
                health -= damage;
            slider.value = health;
            if (health <= 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("TitleScene");
            }
            
         
        }
    }
    IEnumerator wait() {
        yield return new WaitForSeconds(4);
    }
}
