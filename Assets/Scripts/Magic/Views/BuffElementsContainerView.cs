using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public sealed class BuffElementsContainerView : MonoBehaviour
{
    [SerializeField] private BuffElementView m_buffView;
    [SerializeField] private BuffElementView m_debuffView;
    [SerializeField] private BuffElementView m_buffContainer;

    private void OnEnable()
    {
        foreach(var buff in m_buffContainer.Buffs)
        {
            AddElement(buff);
        }

        m_buffContainer.BuffAdded += AddElement;
        m_buffContainer.BuffRemoved += RemoveElement;
    }

    private void OnDisable()
    {
        foreach(var buff in m_buffContainer.Buffs)
        {
            RemoveElement(buff);
        }
        
        m_buffContainer.BuffAdded -= AddElement;
        m_buffContainer.BuffRemoved -= RemoveElement;

    }

    private void AddElement(IBuff buff)
    {
        var element = Instantiate(m_buffView, transform);
        m_elements.Add(buff, element);
    }
    private void RemoveElement(IBuff buff)
    {
        var element = m_elements[buff];
        Destroy(element);

        m_elements.Remove(buff);
    }

}

