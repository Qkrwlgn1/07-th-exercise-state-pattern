using UnityEngine;

public class IdleState : IState
{
    public void HandleInput()
    {
        Debug.Log("아무것도 하지 않는 상태");
    }
}

public class MovingLeftState : IState
{
    public void HandleInput()
    {
        Debug.Log("왼쪽 화살표를 누르는 중");
    }
}

public class MovingRightState : IState
{
    public void HandleInput()
    {
        Debug.Log("오른쪽 화살표를 누르는 중");
    }
}

public class MovingUpState : IState
{
    public void HandleInput()
    {
        Debug.Log("위쪽 화살표를 누르는 중");
    }
}

public class MovingDownState : IState
{
    public void HandleInput()
    {
        Debug.Log("아래쪽 화살표를 누르는 중");
    }
}
