using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Block : MonoBehaviour
{
    public int color;
    public MeshRenderer meshRen;
    public GameManager gm;
    public GameObject xrRig;

    private void Start()
    {
        Invoke("CheckColor", 0.05f);
    }
    public void CheckColor()
    {
        if(color == 0)
        {
            meshRen.material.SetColor("_Color", Color.white);
        } else if(color == 1)
        {
            meshRen.material.SetColor("_Color", Color.red);
        } else if (color == 2)
        {
            meshRen.material.SetColor("_Color", Color.blue);
        } else if(color == 3)
        {
            meshRen.material.SetColor("_Color", Color.yellow);
        } else if (color == 4)
        {
            meshRen.material.SetColor("_Color", Color.black);
        }
        CheckPlayer();
    }

    public void CheckPlayer()
    {
        if (color == gm.gameColor)
        {
            gameObject.GetComponent<TeleportationArea>().teleportationProvider = xrRig.GetComponent<TeleportationProvider>();
        }
        else
        {
            gameObject.GetComponent<TeleportationArea>().teleportationProvider = null;
        }
    }
}

