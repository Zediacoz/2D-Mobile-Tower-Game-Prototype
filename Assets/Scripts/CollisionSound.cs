using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour {

    public AudioSource blockSource;

	// Use this for initialization
	void Start () {

        //blockSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Box")
        {
            blockSource.Play();
            Destroy(collision.gameObject);
        }
    }
}
