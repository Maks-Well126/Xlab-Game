using UnityEngine;

[CreateAssetMenu(fileName = "AoeSpellData", menuName = "Xlab/Magic/Spells/Aoe Spell")]
public class AoeSpellData : BaseSpellData
{
    [SerializeField][Min(0f)] private float m_radius;
    
    public float radius=> m_radius;
}
