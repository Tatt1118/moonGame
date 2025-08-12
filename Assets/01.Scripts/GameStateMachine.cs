using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine : MonoBehaviour
{
    private IGameState currentState;
    //�e�X�e�[�g��o�^
    private Dictionary<GameStateType, BaseState> states = new();

    public void AddState(BaseState state)
    {
        states[state.StateType] = state;
    }
    
    public void ChangeState(IGameState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void Update()
    {
        currentState?.Update();
    }
}
