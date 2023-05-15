using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.transform.Translate(-1.0f, 1.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.transform.Translate(1.0f, 1.0f, 0.0f);
        }
    }
}
