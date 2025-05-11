using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IState currentState;

    private void Start()
    {
        currentState = new IdleState(); // 초기 상태
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ChangeState(new MovingLeftState());
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ChangeState(new MovingRightState());
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            ChangeState(new MovingUpState());
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ChangeState(new MovingDownState());
        }
        else
        {
            ChangeState(new IdleState());
        }

        currentState.HandleInput();
    }

    private void ChangeState(IState newState)
    {
        currentState = newState;
    }
}
