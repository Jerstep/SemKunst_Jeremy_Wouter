//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class IKFollowTarget : MonoBehaviour
//{
//    public Transform target;
//    public Vector3 offset;

//    private Animator[ anim;
//    public List<GameObject> transformObjects;

//    //List of objects in which i look for the right bones and tranform their position

//    // Need a list of bones that follow target
//    // Each bone willbe cycled through to transform its position to the target
//    // Within a set range the bones can move (EXTRA)

//    private void Start()
//    {
//        anim = this.GetComponentsInChildren<Animator>();
//    }

//    private void LateUpdate()
//    {
//        for (int i = 0; i < bonesToTransform.Count; i++)
//        {
//            anim = bonesToTransform[i].GetComponentInParent<Animator>();
//            if (anim.GetBoneTransform(HumanBodyBones.LeftShoulder) != null)
//            {
//                bonesToTransform[i] = anim.GetBoneTransform(HumanBodyBones.LeftShoulder);
//            }
//            else
//            {
//                bonesToTransform[i] = anim.GetBoneTransform(HumanBodyBones.RightShoulder);
//            }
//            bonesToTransform[i].LookAt(target.position);
//            bonesToTransform[i].rotation *= Quaternion.Euler(offset);
//        }





//    }
//}
