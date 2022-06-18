using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    private bool collided = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Ground")
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

        if (!collided && other.transform.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            collided = true;
            other.transform.GetComponent<Scorer>().IncreaseScore();
        }
    }
}
