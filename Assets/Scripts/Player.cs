using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject bodyInventory;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(bodyInventory.activeInHierarchy == true)
            {
                bodyInventory.SetActive(false);
            }
            else
            {
                bodyInventory.SetActive(true);
            }

        }
                
		
	}
}
