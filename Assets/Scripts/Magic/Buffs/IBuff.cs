using UnityEngine.UI;
using System;

public interface IBuff : ICloneable
{
    public string Id { get; }

    public void Initialize(BuffContainer conteiner);

    public void Deinitialize();

    public void Update(float deltatime);
}
