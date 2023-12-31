using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

// Function to identify which direction player paddle will move
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            _direction = Vector2.down;
        } else {
            _direction = Vector2.zero;
        }
    }

// Makes the player paddle move at a consistent speed so it doesn't fluctuate  
    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
