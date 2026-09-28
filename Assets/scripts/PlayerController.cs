using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float JumpForce;
    private Rigidbody2D RB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>(); // letar efter component på objekt
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            {
            RB.linearVelocityY = 0f; // ignore gravity velocity
            RB.AddForceY(JumpForce, ForceMode2D.Impulse);
            }

    }
}
