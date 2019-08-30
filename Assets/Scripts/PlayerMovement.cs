using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private enum MovementDirection { forward, backwards, left, right }

    public Rigidbody rigidBody;
    public float forwardForce;
    public float sideForce;


    void FixedUpdate()
    {
        HandleMovement();
        CheckIfFell();
    }

    private void CheckIfFell()
    {
        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void HandleMovement()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("w"))
        {
            AddforceTo(MovementDirection.forward);
        }
        else if (Input.GetKey("a"))
        {
            AddforceTo(MovementDirection.left);
        }
        else if (Input.GetKey("s"))
        {
            AddforceTo(MovementDirection.backwards);
        }
        else if (Input.GetKey("d"))
        {
            AddforceTo(MovementDirection.right);
        }
    }

    private void AddforceTo(MovementDirection direction)
    {
        float sideTotalForce = sideForce * Time.deltaTime;
        float forwardTotalForce = forwardForce * Time.deltaTime;

        switch (direction)
        {
            case MovementDirection.forward:
                rigidBody.AddForce(0, 0, forwardTotalForce);
                break;

            case MovementDirection.backwards:
                rigidBody.AddForce(0, 0, -forwardTotalForce * 2f);
                break;
            case MovementDirection.left:
                rigidBody.AddForce(-sideTotalForce, 0, 0, ForceMode.VelocityChange);
                break;

            case MovementDirection.right:
                rigidBody.AddForce(sideTotalForce, 0, 0, ForceMode.VelocityChange);
                break;

        }
    }

    public void StopMovement()
    {
        forwardForce = 0f;
        sideForce = 0f;
    }
}