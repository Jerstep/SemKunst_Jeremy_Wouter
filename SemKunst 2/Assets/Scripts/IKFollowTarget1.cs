using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKFollowTarget1 : MonoBehaviour
{
    public Transform target;
    public Transform objectTransform;

    public Vector3 offsetArm1;
    public Vector3 offsetArm2;

    private Animator anim;
    public List<Transform> bonesToTransform;

    private void Start()
    {
        objectTransform = this.transform;
        anim = this.GetComponent<Animator>();
    }

    private void LateUpdate()
    {
        for (int i = 0; i < bonesToTransform.Count; i++)
        {
            bonesToTransform[i].LookAt(target.position);
            bonesToTransform[0].rotation *= Quaternion.Euler(offsetArm1);
            bonesToTransform[1].rotation *= Quaternion.Euler(offsetArm2);
        }


    }
}
