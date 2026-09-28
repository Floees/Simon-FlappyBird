using UnityEngine;

public class DeathWall : MonoBehaviour
{
    private BoxCollider2D BC;

    private void Start()
    {
        BC = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyImmediate(collision.gameObject);
    }
}

