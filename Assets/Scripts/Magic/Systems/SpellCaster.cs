// using UnityEngine;

// public class SpellCaster
// {
//     private Transform m_casterTransform;

//     public SpellCaster(Transform casterTransform)
//     {
//         m_casterTransform = casterTransform;
//     }
//     public void Cast(BaseSpellData spell, Vector3 worldPosition)
//     {
//         if(!spell)
//             {
//                 return;
//             }
//         switch(spell)
//         {
//             case SelfSpellData selfSpell:CastSelf(selfSpell); break;
//             case TargetSpellData targetSpell: CastTarget(targetSpell, worldPosition); break;
//             case NonTargetSpellData nonTargetSpell: CastNonTarget(nonTargetSpell); break;
//             case AoeSpellData aoeSpell:
//                 {
//                     CastAOE(aoeSpell, aoeSpell.isTarget
//                         ? worldPosition
//                         : m_casterTransform.position);
//                     break;
//                 }
//         }
//     }

//     private void CastSelf(SelfSpellData spell) { }
//     private void CastTarget(TargetSpellData spell, Vector3 worldPosition) { }
//     private void CastNonTarget(NonTargetSpellData spell) { }
//     private void CastAOE(AoeSpellData spell, Vector3 worldPosition) { }

// }
