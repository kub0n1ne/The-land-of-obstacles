using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

  public Transform spawnPoint;//Add empty gameobject as spawnPoint
  public float minHeightForDeath;
  public GameObject player; //Add your player
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
 {
   if(player.transform.position.y < minHeightForDeath)
       player.transform.position = spawnPoint.position;
 }
}
