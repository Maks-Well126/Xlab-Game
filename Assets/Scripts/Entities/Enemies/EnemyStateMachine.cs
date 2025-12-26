using System;
using UnityEngine;

public class EnemyStateMachine
{
    public event Action<EnemyState, EnemyData> StateChanged;
    public EnemeState currenState {  get; private set; }

    public EnemyStateMachine()
    {
        currenState = EnemeState.Idle;
    }

    public void ChangeState(EnemyState nextState)
    {
        if (currenState is EnemyState.Dead || currenState == nextState)
        {
            return;
        }

        var previousState = currenState;
        currenState = nextState;

        StateChanged?.Invoke
    }

}
