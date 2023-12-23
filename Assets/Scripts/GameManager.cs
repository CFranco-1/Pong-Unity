using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    private int _playerScore;

    private int _aiScore;

    public void PlayerScores()
    {
        _playerScore++;
       // Debug.Log(_playerScore);

        this.ball.ResetPosition();
    }

    public void AiScores()
    {
        _aiScore++;
       // Debug.Log(_aiScore);

        this.ball.ResetPosition();
    }
}
