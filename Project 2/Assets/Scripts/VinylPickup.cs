using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VinylPickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Vinyl")
        {
            Destroy(other.gameObject);
        }
    }
	
	
}
