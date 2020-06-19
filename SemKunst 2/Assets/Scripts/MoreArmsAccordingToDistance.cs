using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreArmsAccordingToDistance : MonoBehaviour
{
    [SerializeField] Vector3 minPos;
    [SerializeField] Vector3 maxPos;

    public List<Transform> targets;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < targets.Count; i++)
        {
            var distance = Vector3.Distance(this.transform.position, targets[i].transform.position);
            Debug.Log(distance);
            //float newYpos = Remap(distance,0);
            this.transform.position = new Vector3(-distance / 4, transform.position.y, transform.position.z);

            Vector3 lTargetDir = m_Target.position - transform.position;
            lTargetDir.y = 0.0f;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * m_Speed);
        }
    }

    public float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    [SerializeField]
    private Transform m_Target;
    [SerializeField]
    private float m_Speed;
}
