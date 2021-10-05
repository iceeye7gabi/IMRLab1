using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class script : MonoBehaviour
{

    public GameObject myObject1, myObject2;

    private Animator myAnimator1, myAnimator2;

    public float distance;

    private bool isFighting = false;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator1 = myObject1.GetComponent<Animator>();
        myAnimator2 = myObject2.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (myObject1.activeSelf && myObject2.activeSelf)
        {
            if (Vector3.Distance(myObject1.transform.position, myObject2.transform.position) < distance)
            {
                myAnimator1.Play("Base Layer.Attack");
                myAnimator2.Play("Base Layer.Attack");
            }
            else
            {
                myAnimator1.Play("Base Layer.Walk");
                myAnimator2.Play("Base Layer.Walk");
            }
        }

    }
}
