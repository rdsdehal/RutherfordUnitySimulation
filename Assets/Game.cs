using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{

    public GameObject Emitter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;
    public float fireRate;
    private float nextTimeToFire;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey("space") && Time.time >= nextTimeToFire || Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            //The Bullet instantiation happens here.
            GameObject tempBullet;
            tempBullet = Instantiate(Bullet, Emitter.transform.position, Emitter.transform.rotation) as GameObject;
            tempBullet.transform.Rotate(Vector3.left * 90);
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = tempBullet.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);
            Destroy(tempBullet  , 8.0f);
        }
    }
}