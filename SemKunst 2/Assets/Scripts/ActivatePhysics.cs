using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePhysics : MonoBehaviour
{
    Rigidbody rb;
    Vector3 originalPos;
    Quaternion originalRotation;
    private Vector3 velocity = Vector3.zero;

    private float steps = .3f;
    bool canReturn = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        originalPos = this.GetComponent<Transform>().position;
        originalRotation = this.GetComponent<Transform>().rotation;
    }

    void Update()
    {
        if (canReturn)
        {
            transform.position = Vector3.SmoothDamp(transform.position, originalPos, ref velocity, steps);
            transform.rotation = Quaternion.Slerp(transform.rotation, originalRotation, Time.time * steps / 100);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canReturn = false;
            rb.isKinematic = false;
            StartCoroutine(TurnKinematic());
        }
    }

    IEnumerator TurnKinematic()
    {
        yield return new WaitForSeconds(10f);
        canReturn = true;
        rb.isKinematic = true;
    }
}
