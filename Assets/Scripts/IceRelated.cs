using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceRelated : MonoBehaviour
{
    private GameObject cube1, cube2, cube3, cube4;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] SpriteRenderer sr1, sr2, sr3, sr4;

    public bool firstFlip = false;
    public bool flipA = false;
    public bool flipB = false;

    //for changing the spirites based on the hits
    public Sprite afterHits;

    //accessing the penguine script to get the hit data
    PenguinScript penguineScript;
    [SerializeField] GameObject penS;


    void Start()
    {
        penguineScript = penS.GetComponent<PenguinScript>();
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

    public void HitChecker()
    {
        if (penguineScript.hitC1 >= 2) sr1.sprite = afterHits;
        if (penguineScript.hitC2 >= 2) sr2.sprite = afterHits;
        if (penguineScript.hitC3 >= 2) sr3.sprite = afterHits;
        if (penguineScript.hitC4 >= 2) sr4.sprite = afterHits;
    }
}
