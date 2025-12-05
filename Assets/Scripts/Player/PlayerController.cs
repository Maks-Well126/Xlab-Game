using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private void OnValidate()
    {
        if(!m_playerMo)
    }


    private void Start()
    {
        
    }



    private void Update()
    {
        if(Mouse.current.rightButton.wasPressedThisFrame)
        {
            m_playerMovement.SetDestitation(navPoint.Value)
        }
        
    }
}
