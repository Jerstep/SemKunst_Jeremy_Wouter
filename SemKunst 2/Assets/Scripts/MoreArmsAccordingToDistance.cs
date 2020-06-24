using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreArmsAccordingToDistance : MonoBehaviour
{
    [SerializeField] Vector3 minPos;
    [SerializeField] Vector3 maxPos;

    public List<Transform> targets;

    public float speed = 2.5f;
    public float activeDistance = 3f;

    void Start()
    {
        minPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        maxPos = new Vector3(maxPos.x, transform.position.y, transform.position.z);
    }
    
    void Update()
    {

        for (int i = 0; i < targets.Count; i++)
        {
            float smooth = 1.0f - Mathf.Pow(0.5f, Time.deltaTime * speed);
            var distance = Vector3.Distance(this.transform.position, targets[i].transform.position);
            Debug.Log(distance);

            if(distance < activeDistance)
            {
                transform.position = Vector3.Lerp(transform.position, maxPos, smooth);
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, minPos, smooth);
            }
        }
    }
}
