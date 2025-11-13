using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class StunState : AIState
{
    public StunState(AIController controller) : base(controller) { }

    public override void OnEnter()
    {
        // Detenemos al agente
        m_agent.isStopped = true;

        // Iniciamos la corrutina en el AIController (m_controller)
        m_controller.StartCoroutine(StunCoroutine());
    }

    private IEnumerator StunCoroutine()
    {
        // Espera el tiempo configurado en el AIController
        yield return new WaitForSeconds(m_controller.stunDuration);

        // Volvemos a patrulla (asumiendo que PatrolState existe y tiene ese constructor)
        m_controller.ChangeState(new PatrolState(m_controller));
    }

    public override void OnExit()
    {
        // Reactivamos el NavMeshAgent
        m_agent.isStopped = false;
    }

    public override void UpdateState()
    {
        // No hacer nada mientras está aturdido
    }
}
