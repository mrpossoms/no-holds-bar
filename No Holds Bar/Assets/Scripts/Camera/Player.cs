using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera
{

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        { // camera look
            float dx = Input.GetAxis("Mouse X");
            float dy = Input.GetAxis("Mouse Y");

            Rigidbody parent_body = gameObject.GetComponentInParent(typeof(Rigidbody)) as Rigidbody;
            if (null != parent_body)
            {
                parent_body.transform.eulerAngles -= (new Vector3(dy, -dx, 0));
            }
        }
    }
}

}