using System;
using UnityEngine;

[Serializable]
public abstract class BaseBuff : IBuff
{
    [field: SerializeField]
    public string Id { get; private set; }

    protected BuffContainer conteiner { get; private set; }

    public BaseBuff() { }

    protected BaseBuff(string id)
    {
        Id = id;
    }

    public void Initialize(BuffContainer conteiner)
    {
        this.conteiner = conteiner;
        OnInitialized();
    }

    protected virtual void OnInitialized() { }

    public void Deinitialize()
    {
        OnDeinitializing();

        conteiner.Remove(this);
        conteiner = null;
    }

    protected virtual void OnDeinitializing() { }

    public virtual void Update(float deltatime) { }

    public abstract object Clone();
}
