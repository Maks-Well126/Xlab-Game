using UnityEngine;

[CreateAssetMenu(fileName = "TargetSpellData", menuName = "Scriptable Objects/TargetSpellData")]
public class TargetSpellData : BaseSpellData
{

    [SerializeField][Min(0)] private float m_speed;

    public float speed => m_speed;

    
}
