using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComp;

    // Use this for initialization
    void Start () {
        textComp.text = "Hello World";
        textComp.fontSize = 60;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
