using UnityEngine;

public class IdleState : IState
{
    public void HandleInput()
    {
        Debug.Log("�ƹ��͵� ���� �ʴ� ����");
    }
}

public class MovingLeftState : IState
{
    public void HandleInput()
    {
        Debug.Log("���� ȭ��ǥ�� ������ ��");
    }
}

public class MovingRightState : IState
{
    public void HandleInput()
    {
        Debug.Log("������ ȭ��ǥ�� ������ ��");
    }
}

public class MovingUpState : IState
{
    public void HandleInput()
    {
        Debug.Log("���� ȭ��ǥ�� ������ ��");
    }
}

public class MovingDownState : IState
{
    public void HandleInput()
    {
        Debug.Log("�Ʒ��� ȭ��ǥ�� ������ ��");
    }
}
