using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public int i = 0;
    public List<GameObject> players;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject player in players) {
            player.SetActive(false);
        }
        players[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Horizontal")) {
            if (i >= 2)
            {
                i = -1;
            }
   

                if ( i <= 2 )
                {
                i++;
                 foreach (GameObject player in players)
                 {
                     player.SetActive(false);
                 }
                  players[i].SetActive(true);
                
                }          
        }
      
    }

}
