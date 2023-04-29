using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Block")
        {
            Debug.Log("HEELO!");
            if (other.gameObject.GetComponent<Block>().color == gm.gameColor)
            {
                gm.Next();
            }
        }
    }
}
