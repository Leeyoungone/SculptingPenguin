using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinScript : MonoBehaviour
{
    public GameObject happyCat;

    //accessing iceRelated script
    IceRelated iceRelatedS;
    [SerializeField] GameObject iceRel;

    //accessing sliderMovement script
    SliderMovement sliderMovement;
    [SerializeField] GameObject sliderS;

    //positions of the blocks
    public Transform block1, block2, block3, block4;

    //for checking the hit box + which one arrow is pointing at
    public Collider2D arrow;
    public Collider2D cBox1, cBox2, cBox3, cBox4;
    public int hitC1, hitC2, hitC3, hitC4; //int counter for the hits


    void Start()
    {
        iceRelatedS = iceRel.GetComponent<IceRelated>();
        sliderMovement = sliderS.GetComponent<SliderMovement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (sliderMovement.collidedHitbox) boxModification();
        if (iceRelatedS.firstFlip)
        {
            Debug.Log("firstFlip");
            swappingIcePosition(iceRelatedS.firstFlip, iceRelatedS.flipA, iceRelatedS.flipB);
            iceRelatedS.firstFlip = false;
        }
        if (iceRelatedS.flipA)
        {
            Debug.Log("flipA");
            swappingIcePosition(iceRelatedS.firstFlip, iceRelatedS.flipA, iceRelatedS.flipB);
            iceRelatedS.flipA = false;
            iceRelatedS.flipB = true;
        }
        if (iceRelatedS.flipB)
        {
            Debug.Log("flipB");
            swappingIcePosition(iceRelatedS.firstFlip, iceRelatedS.flipA, iceRelatedS.flipB);
            iceRelatedS.flipA = true;
            iceRelatedS.flipB = false;
        }
    }


    public void GoodAnimation()
    {
        Debug.Log("proper hit");
        Instantiate(happyCat, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    public void swappingIcePosition(bool firstFlip, bool flagA, bool flagB)
    {
        if (flagA || firstFlip)
        {
            //swap 1 and 2
            Vector3 temporaryPos1 = block1.transform.position;
            block1.transform.position = block2.transform.position;
            block2.transform.position = temporaryPos1;

            //swap 3 and 4
            Vector3 temporaryPos3 = block3.transform.position;
            block3.transform.position = block4.transform.position;
            block4.transform.position = temporaryPos3;

            Debug.Log("first case");
        }
        if (flagB)
        {
            //swap 2 and 1
            Vector3 temporaryPos2 = block2.transform.position;
            block2.transform.position = block1.transform.position;
            block1.transform.position = temporaryPos2;

            //swap 4 and 3
            Vector3 temporaryPos4 = block4.transform.position;
            block4.transform.position = block3.transform.position;
            block3.transform.position = temporaryPos4;

            Debug.Log("second case");
        }
    }

    public void boxModification()
    {

        //box 1
        if (arrow.IsTouching(cBox1))
        {
            hitC1 += 1;
            Debug.Log("red box hit");
        }

        //box 2
        if (arrow.IsTouching(cBox2))
        {
            hitC2 += 1;
            Debug.Log("blue box hit");
        }

        //box 3
        if (arrow.IsTouching(cBox3))
        {
            hitC3 += 1;
            Debug.Log("green box hit");
        }

        //box 4
        if (arrow.IsTouching(cBox4))
        {
            hitC4 += 1;
            Debug.Log("purple box hit");
        }

        //catch case
        else
        {
            Debug.Log("not touching B");
        }
        iceRelatedS.HitChecker();
    }
}
