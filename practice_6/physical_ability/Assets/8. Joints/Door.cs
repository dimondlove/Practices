using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public HingeJoint HingeJoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            JointSpring jointSpring = HingeJoint.spring;
            jointSpring.targetPosition = 90f;
            HingeJoint.spring = jointSpring;
        }
    }
}
