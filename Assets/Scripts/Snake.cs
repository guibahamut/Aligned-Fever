using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 2.5f;
    public float rotationSpeed = 180f;

    public string inputAxis = "Horizontal";

    float horizontal = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw(inputAxis);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "EnemyTail")
        {
            speed = 0f;
            rotationSpeed = 0f;

            GameObject.FindObjectOfType<GameManager>().EndGame();
        }
    }
}
