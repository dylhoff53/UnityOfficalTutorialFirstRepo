using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneShot : MonoBehaviour
{
    public Rigidbody rig;
    public float bulletSpeed;
    public float counter;
    public void Start()
    {
        rig.velocity = transform.forward * bulletSpeed;
    }

    public void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 5f)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Weapon")
        {
            Destroy(gameObject);
        }
    }
}
