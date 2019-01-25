using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deflect : MonoBehaviour {

    public GameObject Atom;
    public float forceFactor = 10f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddForce((Atom.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime);
    }
}
