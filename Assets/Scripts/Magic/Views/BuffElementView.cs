using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BuffElementView : MonoBehaviour
{
    [SerializeField] private Image m_iconImage;
    [SerializeField] private Image m_timerImage;

    private IBuff m_buff;

    public void Initialize(IBuff buff)
    {

        m_buff = buff;
        gameObject.SetActive(true);
        m_iconImage.sprite = buff.Icon;

    }

    public void DeInitialize()
    {
        m_buff = null;
        gameObject.SetActive(false);

    }

    private void Update()
    {
        if (m_buff is ITimeBuff timeBuff)
        {
          //  m_timerImage.fillAmount = timeBuff.timer / timeBuff123;
        }
        
    }
}


