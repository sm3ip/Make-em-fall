using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    public void ThrowBall(Vector3 dir, float strength)
    {
        gameObject.transform.parent = null;
        GetComponent<Rigidbody>().AddForce(dir * strength, ForceMode.Impulse);
    }
}
