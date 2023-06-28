using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public float gravity = 9.8f;
    public float jumpHeight = 3f;

    private Vector3 moveDirection;
    private CharacterController controller;



    void Start()
    {
        controller = GetComponent<CharacterController>();
        moveDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = transform.forward * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = Mathf.Sqrt(2f * gravity * jumpHeight);
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }
}
