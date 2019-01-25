using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {
    public GameObject impactPrefab;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
    }
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Sphere(Clone)")
        {
            Debug.Log("Hit");
            GameObject impactGO = Instantiate(impactPrefab, c.transform.position, c.transform.rotation);
            Destroy(impactGO,2f);
            Destroy(c.gameObject);
        }
    }
}
