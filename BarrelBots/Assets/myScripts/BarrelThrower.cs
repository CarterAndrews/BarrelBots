using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelThrower : MonoBehaviour {
    public GameObject barrel;
    GameObject currentBarrel;
    public float throwForce;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("launch");
            currentBarrel=Instantiate(barrel, transform.position, Quaternion.identity);
            currentBarrel.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);
            currentBarrel.transform.rotation = Random.rotation;
        }
	}
}
