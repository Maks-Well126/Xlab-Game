using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{

    [SerializeField] private Loading m_loading;
    [SerializeField] private Button m_playButton;
    [SerializeField] private Button m_exitButton;

    private void OnEnable()
    {
        m_playButton.onClick.AddListener(OnPlayClick);
        m_exitButton.onClick.AddListener(OnExitClick);
    }

    private void OnDisable()
    {
        m_playButton.onClick.RemoveListener(OnPlayClick);
        m_exitButton.onClick.RemoveListener(OnExitClick);
    }

    private void OnPlayClick() => PlayClicked?.Invoke();

    private void OnExitClick() => ExitClicked?.Invoke();
}
