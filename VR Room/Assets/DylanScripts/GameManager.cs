using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gameColor;
    public Block[] blocks;
    public Text text;
    public void Next()
    {
        int oldGameColor = gameColor;
        while(oldGameColor == gameColor)
        {
            gameColor = Random.Range(0, 5);
        }
        foreach(Block block in blocks)
        {
            block.CheckPlayer();
        }

        if(gameColor == 0)
        {
            text.text = "Current Color is: White";
        } else if (gameColor == 1)
        {
            text.text = "Current Color is: Red";
        } else if (gameColor == 2)
        {
            text.text = "Current Color is: Blue";
        } else if (gameColor == 3)
        {
            text.text = "Current Color is: Yellow";
        } else if (gameColor == 4)
        {
            text.text = "Current Color is: Black";
        }
    }
}
