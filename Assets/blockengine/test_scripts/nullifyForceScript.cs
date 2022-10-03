using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nullifyForceScript : MonoBehaviour
{
    public GameObject bb;
    float fx, fy, fz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void nullifyVel()
	{
        float Vx1 = bb.GetComponent<Rigidbody>().velocity.x;
        float Vy1 = bb.GetComponent<Rigidbody>().velocity.y;
        float Vz1 = bb.GetComponent<Rigidbody>().velocity.z;

        if (Vx1 != 0)
		{
            fx = (-1 * Vx1);
		}

        if (Vy1 != 0)
        {
            fy = (-1 * Vy1);
        }

        if (Vz1 != 0)
        {
            fz = (-1 * Vz1);
        }

        bb.GetComponent<Rigidbody>().velocity = Vector3.zero; 

    }
    public void nullifyForce()
	{
        bool first = true;
		if (first)
		{
			first = false;
            
		}
		else
		{

        }

		if (bb.GetComponent<Rigidbody>().velocity.magnitude > 0)
		{
            float Vx1 = bb.GetComponent<Rigidbody>().velocity.x;
            float Vy1= bb.GetComponent<Rigidbody>().velocity.y;
            float Vz1= bb.GetComponent<Rigidbody>().velocity.z;

            if (Vx1 != 0)
			{
               // fx = bb.GetComponent<Rigidbody>().velocity.x * bb.GetComponent<Rigidbody>().mass;

            }
           

        }
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}
