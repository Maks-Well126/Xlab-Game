using UnityEngine;

[CreateAssetMenu(fileName = "NonTargetSpellData", menuName = "Scriptable Objects/NonTargetSpellData")]
public class NonTargetSpellData : BaseSpellData
{

    [SerializeField][Min(0)] private float m_range;
    [SerializeField][Min(0)] private float m_duration;
    [SerializeField][Min(0f)] private float m_effectinterval;
        
    public float range => m_range;
    
    public float duration => m_duration;

    public float effectinterval => m_effectinterval;
}
