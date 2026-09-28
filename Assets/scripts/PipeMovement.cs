using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float HorizontalForce;
    private Rigidbody2D RB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.AddForceX(-HorizontalForce);
    }
}
