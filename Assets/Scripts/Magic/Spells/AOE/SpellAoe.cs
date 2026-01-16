using UnityEngine;
using System.Collections.Generic;

public sealed class SpellAoe : MonoBehaviour, ISpellAoe
{
    public void Initialize(Vector3 targetPosition, float radius, IReadOnlyCollection<IEffect> effects)
    {
        var colliders = Physics.OverlapSphere(targetPosition, radius, gameObject.layer);

        foreach (var collider in colliders)
        {
            var effectables = collider.GetComponents<IEffectable>();
            effects.ApplyEffects(effectables);
        }

        Debug.Log("SpellAoe initialized");
    }
}
