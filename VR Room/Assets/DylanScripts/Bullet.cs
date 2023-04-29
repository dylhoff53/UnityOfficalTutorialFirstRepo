using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
        if(collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            collision.gameObject.transform.position = new Vector3(0,0,0);
        }
    }
}
