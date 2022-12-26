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
    void Update()
    {
        if (!(iceRelatedS.flipA && iceRelatedS.flipB))
        {
            swappingIcePosition(iceRelatedS.flipA, iceRelatedS.flipB);
        }
        if (iceRelatedS.flipA)
        {
            iceRelatedS.flipA = false;
            iceRelatedS.flipB = true;
            swappingIcePosition(iceRelatedS.flipA, iceRelatedS.flipB);
        }
        if (iceRelatedS.flipB)
        {
            iceRelatedS.flipA = true;
            iceRelatedS.flipB = false;
            swappingIcePosition(iceRelatedS.flipA, iceRelatedS.flipB);
        }
        else
        {
            Debug.Log("missed case");
        }
    }


    public void GoodAnimation()
    {
        Debug.Log("proper hit");
        Instantiate(happyCat, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    public void swappingIcePosition(bool flagA, bool flagB)
    {
        if (flagA)
        {
            //swap 1 and 2
            Vector3 temporaryPos1 = block1.transform.position;
            block1.transform.position = block2.transform.position;
            block2.transform.position = temporaryPos1;

            //swap 3 and 4
            Vector3 temporaryPos3 = block3.transform.position;
            block3.transform.position = block4.transform.position;
            block4.transform.position = temporaryPos3;
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
        }
    }
}
