using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public Rigidbody2D plantRb;
    public float speed;
    public float maxTimer;
    private float currentTimer;
    public bool shouldMove;
    public bool moveDown;

    [Header("Spawn Variables")]
    public int randomNumber;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;

    [Header("Stop Script References")]
    public GameObject stopPoint;
    private StopTrigger stopScript;
    
    //Need some sort of game manager object that
    //- Times the mini game.
    // - Checks if we scored by checking the proper variable
    // - keeps high score (unless its managed by a high score manager instead)
    //HS manager could be like...
    // if script on scene isnt null, check if we scored, if do, update score, if not, dont

    
   
    void Start()
    {
        stopScript = stopPoint.GetComponent<StopTrigger>();
        currentTimer = maxTimer;
        randomNumber = Random.Range(1, 3);

        if (randomNumber == 1)
        {
            transform.position = spawn1.transform.position;
        }
        
        if (randomNumber == 2)
        {
            transform.position = spawn2.transform.position;
        }
        
        if (randomNumber == 3)
        {
            transform.position = spawn3.transform.position;
        }

    }

    
    void Update()
    {
        currentTimer = currentTimer - Time.deltaTime;
        
        if (currentTimer <= 0 && stopScript.stopPlantMoving == false)
        {
            shouldMove = true;
        }
        else
        {
            shouldMove = false;
        }
    }

    private void FixedUpdate()
    {
        if (shouldMove)
        {
            plantRb.velocity = Vector2.up * speed * Time.fixedDeltaTime;
        }
        else
        {
            plantRb.velocity = Vector2.zero;
        }

        

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
    
    
}
