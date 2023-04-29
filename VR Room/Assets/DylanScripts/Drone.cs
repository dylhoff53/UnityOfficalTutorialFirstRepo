using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public Transform target;
    public Transform aim;
    public GameObject barrel;
    public float interval;
    public float counter;
    public GameObject bullet;
    public Rigidbody rb;
    public bool isDead;
    public int var;

    public void Update()
    {
        if(isDead == false)
        {
            counter += Time.deltaTime;
            transform.LookAt(target);
            barrel.transform.LookAt(aim);
            transform.Translate(this.transform.forward / var, Space.World);
            if (counter >= interval)
            {
                ShootBullet();
                counter = 0f;
            }
        }
    }

    public void ShootBullet()
    {
        Instantiate(bullet, barrel.transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Weapon" && isDead == false)
        {
            rb.useGravity = true;
            isDead = true;
        }
    }
}
