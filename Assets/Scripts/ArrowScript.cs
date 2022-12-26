using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject arrowObject;

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
            arrowObject.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }

    public void clickedButtonUp()
    {
        if (!Input.GetKeyDown("space"))
        {
            arrowObject.transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z);
        }
    }
}
