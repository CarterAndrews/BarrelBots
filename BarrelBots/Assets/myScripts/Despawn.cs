using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {

    public float timeOut;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, timeOut);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
