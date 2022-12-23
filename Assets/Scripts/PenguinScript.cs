using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinScript : MonoBehaviour
{
    public GameObject happyCat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoodAnimation()
    {
        Debug.Log("proper hit");
        Instantiate(happyCat, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
