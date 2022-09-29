using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float forceAmount = 5;

    Rigidbody player;

    Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        pos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.AddForce(Vector2.up * forceAmount);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.AddForce(Vector2.down * forceAmount);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.AddForce(Vector2.left * forceAmount);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.AddForce(Vector2.right * forceAmount);
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, 2f);
        }

    }
}
