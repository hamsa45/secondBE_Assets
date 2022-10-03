using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    Vector3 velocity;
    public float v;
    // Start is called before the first frame update
    void Start()
    {
       // velocity = transform.GetComponent<Rigidbody>().velocity;
        transform.GetComponent<Rigidbody>().AddForce(new Vector3(v, 0, 0));
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("present velocity of " + this.gameObject.name + " is " + transform.GetComponent<Rigidbody>().velocity);
    }
}
