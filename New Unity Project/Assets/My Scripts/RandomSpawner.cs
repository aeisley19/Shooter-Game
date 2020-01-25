using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject[] astroid;
    public float spawnTime = 2; //Time to spawn in seconds

    private int randomArray;
    private float timer = 0; //timer count unill spawn

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime) //if timer reaches time until spawn, call Spawn() and reset timer
        {
            Spawn();
            timer = 0;
            Debug.Log(Camera.main.farClipPlane);
        }
    }

    //spawns a random astroid game object from between a random height between 600 and room height 
    public void Spawn()
    {
        randomArray = Random.Range(0, astroid.Length); 

        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(
new Vector3(Random.Range(0, Screen.width), Random.Range(600,
Screen.height), Camera.main.farClipPlane / 2));

        Instantiate(astroid[randomArray], screenPosition, Quaternion.identity);
    }
}
