using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject arrowObject;

    public Transform penguinLocation;

    public int box1, box2, box3, box4;
    public bool box1hit, box2hit, box3hit, box4hit;

    // Start is called before the first frame update
    void Start()
    {
        arrowObject = GameObject.Find("Arrow");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void clickedButtonDown()
    {
        if (!Input.GetKeyDown("space"))
        {
            arrowObject.transform.position = new Vector3(penguinLocation.position.x - 2.8f, penguinLocation.position.y - 0.4f, penguinLocation.position.z);
        }
    }

    public void clickedButtonUp()
    {
        if (!Input.GetKeyDown("space"))
        {
            arrowObject.transform.position = new Vector3(penguinLocation.position.x - 2.8f, penguinLocation.position.y + 1.6f, penguinLocation.position.z);
        }
    }
}
