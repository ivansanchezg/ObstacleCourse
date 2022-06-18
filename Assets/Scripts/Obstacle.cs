using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private bool collided = false;
    private void OnCollisionEnter(Collision other)
    {
        if (!collided && other.transform.tag == "Player") 
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.red;
            collided = true;
            other.transform.GetComponent<Scorer>().IncreaseScore();
        }
    }
}
