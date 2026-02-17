using System;
using System.Collections.Generic;

public class StateMachine
{
    private IState m_state;
    private Dictionary<Type, IState> m_states = new();
    public void Initialize(params IState[] states)
    {
        if (m_states.Count > 0) return;
        
    }
    public void ChangedState<T>()
        where T: IState
    {
        m_state?.Exit();
        {
            m_state = m_states[typeof(T)];
        }
        m_state.Enter();
    }
}

public interface IState
{
    public void Enter();
    public void Exit();
}

public class MainMenuState : IState
{
    private readonly StateMachine m_stateMachine;
    private readonly MainMenuView m_mainMenuView;

    public MainMenuState(
        StateMachine stateMachine,
        MainMenuView mainMenuView)
    {
        m_stateMachine = stateMachine;
        m_mainMenuView = mainMenuView;

        m_mainMenuView.gameObject.SetActive(false);
    }

    public void Enter()
    {
        m_mainMenuView.gameObject.SetActive(true);
       // m_mainMenuView.PlayClicked += OnPlayClick();

    }
    public void Exit() { }
    
}
public class PauseMenuState : IState
{
    public void Enter() { }
    public void Exit() { }
}

public class GameplayState : IState
{
    private readonly StateMachine m_stateMachine;
    private readonly SpawnerEnemy m_spawnerEnemy;
    public GameplayState(
        StateMachine stateMachine,
        SpawnerEnemy spawnerEnemy)
    {   
        m_spawnerEnemy = spawnerEnemy;
        m_stateMachine = stateMachine;
    }
    public void Enter() { }
    public void Exit() { }
}

public class DeadState : IState
{
    public void Enter() { }
    public void Exit() { }
}



