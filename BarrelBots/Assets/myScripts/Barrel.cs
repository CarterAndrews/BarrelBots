using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour {
    public GameObject particleSystem;
    public GameObject shatteredBarrel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("enemy"))
        {
            Instantiate(particleSystem, transform.position, Quaternion.EulerRotation(0, 0, 0));
            Instantiate(shatteredBarrel, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
