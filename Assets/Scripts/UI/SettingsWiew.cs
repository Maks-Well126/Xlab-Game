using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsWiew : MonoBehaviour
{
    public event Action Closed;
    [SerializeField] private Slider m_musicSlider;
    [SerializeField] private Slider m_soundsSlider;
    [SerializeField] private TMP_Text m_musicValueText;
    [SerializeField] private TMP_Text m_soundsValueText;
    [SerializeField] private Button m_acceptButton;

    private AudioService m_audioService;

    private void Start()
    {
        m_audioService = ServiceLocator.Resolve<AudioService>();
        IninializeSliders();

    }

    private void OnEnable()
    {
        IninializeSliders();
        m_musicSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        m_soundsSlider.onValueChanged.AddListener(OnSoundsVolumeChanged);
        m_acceptButton.onClick.AddListener(OnAcceptClick);
    }
    void OnDisable()
    {
        m_musicSlider.onValueChanged.RemoveListener(OnMusicVolumeChanged);
        m_soundsSlider.onValueChanged.RemoveListener(OnSoundsVolumeChanged);
        m_acceptButton.onClick.RemoveListener(OnAcceptClick);
    }

    private void IninializeSliders()
    {
        if (m_audioService == null)
            return;
        m_musicSlider.SetValueWithoutNotify(m_audioService.MusicVolume);
        m_soundsSlider.SetValueWithoutNotify(m_audioService.SoundsVolume);
        SetValueText(m_musicValueText, m_audioService.MusicVolume);
        SetValueText(m_soundsValueText, m_audioService.SoundsVolume);
    }

    private void OnMusicVolumeChanged(float value)
    {
        m_audioService?.SetMusicVolume(value);
        SetValueText(m_musicValueText, value);
    }
        

    private void OnSoundsVolumeChanged(float value)
    {
        m_audioService?.SetSoundsVolume(value);
        SetValueText(m_soundsValueText, value);
    }

    private static void SetValueText(TMP_Text label, float value) =>
        label.text = Mathf.RoundToInt(value * 100f).ToString();

    private void OnAcceptClick()
    {
        Closed?.Invoke();
        gameObject.SetActive(false);
    }






}
