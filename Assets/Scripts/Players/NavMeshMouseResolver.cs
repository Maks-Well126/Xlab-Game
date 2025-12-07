using UnityEngine;
using UnityEngine.AI;

public class NavMeshMouseResolver : MonoBehaviour
{
    [SerializeField] private LayerMask m_LayerMask = ~0;
    [SerializeField][Min(0)] private float m_raycastDistance = 1000f;
    [SerializeField][Min(0)] private float m_navMeshSamplemaxDistance = 100f;

    private Camera m_camera;

    public void Initialize(Camera camera)
    {
        m_camera = camera;
    }
   
    public Vector3? GetNavMeshPoint(Vector3 mousePosition)
    {

         var ray = m_camera.ScreenPointToRay(mousePosition);
            
            if(Physics.Raycast(ray, out RaycastHit hit, m_raycastDistance, m_LayerMask))
            {
                if(NavMesh.SamplePosition(hit.point, out var navHit, m_navMeshSamplemaxDistance, NavMesh.AllAreas))
                {
                    return navHit.position;
                }
            }


            return null;
    }

}
