using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class AccelerationBuff : TimedBuff
{
    [SerializeField] private float m_value;
    private IAcceleration m_acceleration;

    public AccelerationBuff(
        string id,
        float duration,
        float value)
        : base(id, duration)
    {
        m_value = value;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        m_acceleration = conteiner.GetComponent<IAcceleration>();

        if(m_acceleration is null )
        {
           // OnDeInitialized();
        }
        else
        {
            m_acceleration.IncreaseAcceleration(m_value);
        }
    }

    protected override void OnDeInitialized()
    {
        m_acceleration?


    }


    public override IBuff Clone()
    {
        throw new NotImplementedException();
    }
}

