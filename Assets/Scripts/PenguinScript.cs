using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinScript : MonoBehaviour
{
    public GameObject happyCat;

    //accessing iceRelated script
    IceRelated iceRelatedS;
    [SerializeField] GameObject iceRel;

    //positions of the blocks
    public Transform block1, block2, block3, block4;



    // Start is called before the first frame update
    void Start()
    {
        iceRelatedS = iceRel.GetComponent<IceRelated>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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

            Debug.Log("first casE");
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
}
