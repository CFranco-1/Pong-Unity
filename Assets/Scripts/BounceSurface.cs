using UnityEngine;

public class BounceSurface : MonoBehaviour
{
    public float bounceStrength;

    // function to increase speed everytime it touches a surface. will increase speed in the opposite direction it was hit in 
    // to increase the difficulty of the game as time goes on
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
