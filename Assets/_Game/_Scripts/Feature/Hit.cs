using UnityEngine;

public class Hit : MonoBehaviour, IHitMovable
{
    public Rigidbody2D rg;
    public float speed;
    public GameObject hitObject;
    public float Speed
    {
        get => speed;
        set => speed = value;
    }

    private void FixedUpdate()
    {
        OnMoveHorizontal(speed);
    }
    public void OnMoveHorizontal(float speed)
    {
        rg.linearVelocity = new Vector2(speed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            hitObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            hitObject = null;
        }
    }

}
