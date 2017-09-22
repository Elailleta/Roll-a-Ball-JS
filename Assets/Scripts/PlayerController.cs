using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public GameObject floor;
    private Rigidbody rb;

    private int count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

        SetCountText();
        winText.text = "";

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("destroy"))
        {
            other.gameObject.SetActive(false);
        }
            if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 1)
        {
            speed = speed - 1;
        }
        if (count == 2)
        {
            speed = speed - 1;
        }
        if (count == 3)
        {
            speed = speed - 1;
        }
        if (count == 4)
        {
            speed = speed - 1;
        }
        if (count == 5)
        {
            speed = speed - 1;
        }
        if (count == 6)
        {
            speed = speed - 1;
        }
        if (count == 7)
        {
            speed = speed - 1;
        }
        if (count == 8)
        {
            speed = speed - 1;
        }
        if (count == 9)
        {
            speed = speed + 10;
        }
        if (count == 8)
        {
            winText.text = "Drop Down!";
            floor.SetActive(false);
        }
        if (count == 16)
        {
            speed = speed - 12;
            winText.text = "You Win!";
        }
    }
}
