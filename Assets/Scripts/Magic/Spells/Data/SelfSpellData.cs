
using UnityEngine;

[CreateAssetMenu(fileName = "SelfSpellData", menuName = "Scriptable Objects/SelfSpellData")]
public class SelfSpellData : BaseSpellData
{
    [SerializeField] private bool m_isTarget;


    public bool isTarget => m_isTarget;
}
