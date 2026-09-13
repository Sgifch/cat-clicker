using UnityEngine;

public class Border : MonoBehaviour
{
    public float speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject hit = collision.gameObject;
        float currentSpeed = hit.GetComponent<IHitMovable>().Speed;
        hit.GetComponent<IHitMovable>().Speed = currentSpeed * -1;

    }
}
