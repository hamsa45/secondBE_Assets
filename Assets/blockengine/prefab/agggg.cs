using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class agggg : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			
			animator.Play("Dance1");
		}
		else if (Input.GetKeyDown(KeyCode.Q))
		{
			animator.Play("Jogging");
			
		}





	}
}
