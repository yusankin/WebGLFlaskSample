using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryCollider : MonoBehaviour
{

    private Vector3 _initialPos;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _initialPos = this.transform.position;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "RetryBoard")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            this.transform.position = _initialPos;
            Debug.Log("Collider");
        }
    }
}
