using UnityEngine;
using System;
using System.Collections;

public class create : MonoBehaviour {
	public GameObject[] mino;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
				System.Random rnd= new System.Random(); 
				int n = rnd.Next(7);

				Instantiate(mino[n],transform.position,transform.rotation);
		}

	//void OnTriggerEnter2D () {}

	
	}
}
