using UnityEngine;

public class AiPaddle : Paddle
{
    public Rigidbody2D ball;

    // Function for the AI Paddle to follow the movement of the ball so it can pass it back to the player
    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.velocity.y > this.transform.position.y) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
