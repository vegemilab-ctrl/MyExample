using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    public float interval = 1f;

    private float waitTime = 0f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        //타겟 없으면 목적지 설정 안함.
        if (target == null)
            return;

        //대기완료상태가 아니면 목적지 갱신 안함.
        if (waitTime > Time.time)
            return;

        waitTime += interval;

        //목적지 갱신
        agent.SetDestination(target.position);
    }
}
