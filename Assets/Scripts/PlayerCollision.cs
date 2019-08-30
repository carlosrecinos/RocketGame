using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovement.StopMovement();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
