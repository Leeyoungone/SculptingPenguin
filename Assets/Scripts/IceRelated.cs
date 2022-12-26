using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceRelated : MonoBehaviour
{
    private GameObject cube1, cube2, cube3, cube4;
    //public Transform block1, block2, block3, block4;
    [SerializeField] SpriteRenderer spriteRenderer;

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

            //swapping position boolean logic
            if (!(flipA && flipB))
            {
                flipA = true;
                //swappingIcePosition(flipA, flipB);
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
            } else
            {
                Debug.Log("missing case yikes");
            }
        }
    }

    //public void swappingIcePosition(bool flagA, bool flagB)
    //{
    //    if (flagA)
    //    {
    //        //swap 1 and 2
    //        Vector3 temporaryPos1 = cube1.transform.position;
    //        cube1.transform.position = cube2.transform.position;
    //        cube2.transform.position = temporaryPos1;

    //        //swap 3 and 4
    //        Vector3 temporaryPos3 = cube3.transform.position;
    //        cube3.transform.position = cube4.transform.position;
    //        cube4.transform.position = temporaryPos3;
    //    }
    //    if (flagB)
    //    {
    //        //swap 2 and 1
    //        //swap 4 and 3
    //    }
    //}
}
