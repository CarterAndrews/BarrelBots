using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreCounter : MonoBehaviour {
    public int scoreCount = 0;
    Text score;
	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void inc(int x)
    {
        scoreCount += x;
        score.text = "bots: " + scoreCount;
    }
}
