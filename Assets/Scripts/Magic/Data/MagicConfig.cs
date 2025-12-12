using UnityEngine;

[CreateAssetMenu(fileName = "MagicConfig", menuName = "Scriptable Objects/MagicConfig")]
public sealed class MagicConfig : ScriptableObject
{

    [SerializeField] private ElementData m_elementData;
    [SerializeField] private SpellDatabase m_spellsDateBase;

    [SerializeField][Min(0)] private int m_maxElements = 3;
    [SerializeField][Min(1)] private float m_cancelColdown = 0.3f;

    public ElementData elementData => m_elementData;
    public SpellDatabase SpellDatabase => m_spellsDateBase;
    public int MaxElements => m_maxElements;

    public float CancelColdown => m_cancelColdown;
    
}
