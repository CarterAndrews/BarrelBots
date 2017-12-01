using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public GameObject robot;
    public float spawnRate;
    float counter=0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (counter > spawnRate)
        {
            spawn();
            counter = 0;
        }
        counter++;
	}
    public void spawn()
    {
        Instantiate(robot, transform.position, Quaternion.identity);
    }
}
