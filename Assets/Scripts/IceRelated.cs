using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceRelated : MonoBehaviour
{
    private GameObject cube1, cube2, cube3, cube4;
    //public Transform block1, block2, block3, block4;
    [SerializeField] SpriteRenderer spriteRenderer;

    public bool firstFlip = false;
    public bool flipA = false;
    public bool flipB = false;

    // Start is called before the first frame update
    void Start()
    {
        cube1 = GameObject.Find("Block1");
        cube2 = GameObject.Find("Block2");
        cube3 = GameObject.Find("Block3");
        cube4 = GameObject.Find("Block4");
    }

    // Update is called once per frame
    public void clickedFlip()
    {
        if (!Input.GetKeyDown("space"))
        {
            //visuals flipping sprites (FOR NOW)
            if (spriteRenderer.flipX) spriteRenderer.flipX = false;
            else spriteRenderer.flipX = true;

            if(!firstFlip && !flipA)
            {
                firstFlip = true;
            }
            if(flipA)
            {
                flipA = false;
                flipB = true;
                //swappingIcePosition(flipA, flipB);
            }
            if (flipB)
            {
                flipA = true;
                flipB = false;
                //swappingIcePosition(flipA, flipB);
            }
        }
    }
}
