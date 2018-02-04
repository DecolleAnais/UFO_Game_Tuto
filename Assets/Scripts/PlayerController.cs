using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float m_speed = 10f;
    public Text m_countText;
    public Text m_winText;

    private Rigidbody2D m_rb;
    private int m_count;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_count = 0;
        SetCountText();
        m_winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        m_rb.AddForce(movement * m_speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            m_count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        m_countText.text = "Count : " + m_count.ToString();
        if(m_count >= 14)
        {
            m_winText.text = "You win !";
        }
    }

}
