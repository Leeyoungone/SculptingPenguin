using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject arrowObject;

    public Transform block2l, block4l;


    // Start is called before the first frame update
    void Start()
    {
        //block2l = GameObject.Find("Block2").transform.position.y;
        //block4l = GameObject.Find("Block4");
        arrowObject = GameObject.Find("Arrow");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("block2l y value " + block2l.position.y);
    }

    public void clickedButtonDown()
    {
        if (!Input.GetKeyDown("space"))
        {
            arrowObject.transform.position = new Vector3(block4l.position.x + 2.5f, block4l.position.y, block4l.position.z);
        }
    }

    public void clickedButtonUp()
    {
        if (!Input.GetKeyDown("space"))
        {
            arrowObject.transform.position = new Vector3(block2l.position.x + 2.5f, block2l.position.y, block2l.position.z);
        }
    }
}
