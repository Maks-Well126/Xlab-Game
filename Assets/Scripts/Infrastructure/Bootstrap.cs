//using Players;
//using UnityEngine;

//public class Bootstrap : MonoBehaviour, IState
//{
//    [SerializeField] private MouseResolver m_mouseResolver;

//    private StateMachine m_statemachine;

//    public void Initialize(StateMachine stateMachine)
//    {
//        m_statemachine = stateMachine;
//    }

//    public void Enter()
//    {
//        ServiceLocator.Register(m_mouseResolver);

//        var playerFactory = new PlayerFactory("Prefabs/player");

//        ServiceLocator.Register<PlayerFactory>(playerFactory);
//        ServiceLocator.Register<IPlayerFactorySettings>(playerFactory);


//        m_statemachine.ChangedState<GameplayState>();
//    }

//    public void Exit() { }

//}
