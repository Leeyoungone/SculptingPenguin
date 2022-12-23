using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : MonoBehaviour
{
    public GameObject iceBlock;


    private void Awake()
    {
        iceBlock = GameObject.Find("Block");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickedFlip()
    {
        transform.position = new Vector3((transform.position.x * -1), transform.position.y, transform.position.z);
    }
}
