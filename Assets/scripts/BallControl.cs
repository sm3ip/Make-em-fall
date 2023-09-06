using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public int deathCountDown;

    public void Update()
    {
        deathCountDown -= 1;
        if (deathCountDown<0)
        {
            death();
        }
    }

    public void ThrowBall(Vector3 dir, float strength)
    {
        gameObject.transform.parent = null;
        GetComponent<Rigidbody>().AddForce(dir * strength, ForceMode.Impulse);
    }

    private void death()
    {
        Destroy(gameObject);
    }
}
