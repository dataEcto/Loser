using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTrigger : MonoBehaviour
{
    public GameObject pPlant;
    private PlantScript pScript;
    public bool stopPlantMoving;
    
    void Start()
    {
        pScript = pPlant.GetComponent<PlantScript>();
        stopPlantMoving = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            //Stop the plants movement here.
            stopPlantMoving = true;
            Debug.Log("Stop Plant!");
        }
    }
}
