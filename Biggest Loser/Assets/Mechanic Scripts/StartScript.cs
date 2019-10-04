using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    int index;
    
    void Start()
    {
        index = Random.Range(1,5);
    }

    
    void Update()
    {
        Debug.Log(index);
    }

    public void chooseRandomStart()
    {
        SceneManager.LoadScene(index);
    }
}
