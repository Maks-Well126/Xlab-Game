using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class BuffEffect : IEffect
{
    [SerializeReferenceDropdown]
    [SerializeReference] private IBuff[] m_buffs;

    public void Apply(IEffectable effectable)
    {
        if(effectable is BuffContainer container)
        {
            foreach(var buff in m_buffs)
            {
                container.Add(buff.Clone();
            }
        }
    }
}