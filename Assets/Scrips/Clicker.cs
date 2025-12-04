using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Clicker : MonoBehaviour
{
    //AI 에이전트 배열
    public NavMeshAgent[] agents;
    //클릭했을 때 감지할 수 있는 레이어
    public LayerMask mask;

    public Transform firstDestination;

    public void Start()
    {
        foreach (var agent in agents)
        {
            //AI에게 목적지를 설정하는 함수
            agent.SetDestination(firstDestination.position);
        }
    }

    //Click했을 때 호출되는 함수
    public void OnClick()
    {
        //마우스 현재 위치값을 가지고 카메라가 바라보는 위치를 추적할 수 있다.
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        //카메라가 바라보는 위치에 존재하는 3d 콜라이더를 감지해서 감지되면 true 반환,
        //out 키워드로 감지한 콜라이더 정보를 알 수 있다.
        if(Physics.Raycast(ray, out RaycastHit hit, 1000f, mask))
        {
            foreach(var agent in agents)
            {
                //AI에게 목적지를 설정하는 함수
                agent.SetDestination(hit.point);
            }
        }
    }
}
