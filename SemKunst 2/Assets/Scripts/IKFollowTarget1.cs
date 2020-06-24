using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKFollowTarget1 : MonoBehaviour
{
    public Transform target;

    public Vector3 offsetArm1;
    public Vector3 offsetArm2;

    private Animator anim;
    public List<Transform> bonesToTransform;

    [SerializeField]
    private Transform m_Target;
    [SerializeField]
    private float m_Speed;


    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < bonesToTransform.Count; i++)
        {
            //bonesToTransform[i].LookAt(target.position);
            //bonesToTransform[0].rotation *= Quaternion.Euler(offsetArm1);
            //bonesToTransform[1].rotation *= Quaternion.Euler(offsetArm2);

            Vector3 lTargetDir = m_Target.position - transform.position;
            lTargetDir.y = 0.0f;
            transform.rotation = Quaternion.RotateTowards(bonesToTransform[i].transform.rotation, Quaternion.LookRotation(lTargetDir), Time.deltaTime * m_Speed);
        }
    }   
}
