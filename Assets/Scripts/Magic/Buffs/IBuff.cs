using UnityEngine.UI;
using System;
using UnityEngine;

public interface IBuff
{
    public string Id { get; }
    public Sprite Icon { get; }


    public void Initialize(BuffContainer conteiner);

    public void Deinitialize();

    public void Update(float deltatime);

    public IBuff Clone();
}

public interface ITimeBuff : IBuff
{
    public float duration { get; }
    public float timer { get; }

}

