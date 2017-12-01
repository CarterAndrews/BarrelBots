using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class myRobots : MonoBehaviour {
    public float moveSpeed;
    NavMeshAgent agent;
    Transform target;
    GameObject scoreText;
    public GameObject broken;
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = moveSpeed;
        agent.SetDestination(target.position);
        scoreText = GameObject.FindGameObjectWithTag("score");
    }
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            scoreText.GetComponent<scoreCounter>().inc(1);
            Destroy(gameObject);
        }
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Barrel"))
        {
            die();
        }
        else if (collision.collider.CompareTag("Target"))
        {
            ;
        }
        else
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }
    public void die()
    {
        Instantiate(broken, transform.position, transform.rotation);
        agent.enabled = false;
        Destroy(gameObject);
    }
}
