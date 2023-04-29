using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float counter;
    public float interval;

    public void Update()
    {
        counter += Time.deltaTime;
        if (counter >= interval)
        {
            gameObject.transform.position = new Vector3(Random.Range(-3.5f, 3.5f), 0.5f, -50f);
            ShootBullet();
            counter = 0f;
        }
    }

    public void ShootBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
