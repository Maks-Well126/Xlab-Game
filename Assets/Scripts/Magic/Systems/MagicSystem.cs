// using System;
// using System.Collections.Generic;
// using UnityEngine;

// public class MagicSystem : MonoBehaviour
// {
//     public event Action SpellCancelled;
//     public event Action<MagicState> StateChanged;
//     public event Action<IReadOnlyList<ElementType>> ElementChanged
//     {
//         add => spellPreparation.ElementsChanged += value;

//     }

//     [SerializeField] private MagicConfig m_config;


//     private MagicState m_state;
//     private SpellPreparation m_spellPreparation =>
//         m_spellPreparation ??=new SpellPreparation(m_config);

//     public void AddElement(ElementType element)
//     {
//         if(state is MagicState.Coldown or MagicState.Casting)
//         {
//             return;
//         }

//         SpellPreparation.AddElement(element);
//         state = MagicState.Preparation;
//     }

//     public bool TryCastSpell(out BaseSpellData spell)
//     {
//         spell = null;
//         return false;
//     }

//     private void CancelSpell()
//     {
//         if(state is MagicState.Preparation)
//         {
//             SpellPreparation.Clear();
//             SpellPreparation? Invoke();
//         }
//     }

//     private void StartCooldown()
//     {
//         if(m_cooldownCoroutine is not  null)
//         {
//             StopCoroutine(m_cooldownCoroutine);
//         }

//         m_cooldownCoroutine = StartCoroutine(ColdownRoutine());
//     }
//     private IEnumerator ColdownRoutine()
//     {
//         state = MagicState.Coldown;
//         yield return new WaitForSeconds(m_config.CancelColdown);
//         state = MagicState.Idle;

//         m_cooldownCoroutine = null;
//     }

//     public enum MagicState
//     {
//         Idle,
//         Preparation,
//         Coldown,
//         Casting,


//     }
// }
