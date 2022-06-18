using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (x != 0 && z != 0)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        transform.Translate(x, 0, z);
    }
}
