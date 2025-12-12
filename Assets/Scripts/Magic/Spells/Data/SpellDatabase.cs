using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpellDatabase", menuName = "Scriptable Objects/SpellDatabase")]
public class SpellDatabase : ScriptableObject
{

    [SerializeField] private BaseSpellData[] m_spells;

    public IReadOnlyList<BaseSpellData> Spells => m_spells;
    
}
