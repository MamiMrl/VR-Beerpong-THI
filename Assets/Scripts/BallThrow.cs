using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public LineRenderer trajectory;
    public float throwForce = 10f;

    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 throwVelocity;
    private bool isThrowing = false;

    void Update()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            if (!isThrowing)
            {
                startPos = Input.mousePosition;
                startPos.z = 0;
                isThrowing = true;
                trajectory.enabled = true;
            }
            else
            {
                endPos = Input.mousePosition;
                endPos.z = 0;
                throwVelocity = (endPos - startPos) * throwForce;
                throwVelocity.z = 0;
                trajectory.SetPosition(0, transform.position);
                trajectory.SetPosition(1, transform.position + throwVelocity);
            }
        }
        else if (isThrowing)
        {
            isThrowing = false;
            trajectory.enabled = false;
            GetComponent<Rigidbody>().AddForce(throwVelocity, ForceMode.VelocityChange);
        }
    }
}
