using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alter : MonoBehaviour
{
    public int counter;
    public GameObject Key;
    public GameObject spawn;

    public void AddCount()
    {
        counter++;
        if(counter == 3)
        {
            Instantiate(Key, spawn.transform.position, Quaternion.identity);
        }
    }
}
