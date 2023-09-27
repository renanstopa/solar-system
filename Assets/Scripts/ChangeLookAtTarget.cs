using UnityEngine;

namespace SolarSystem
{
    public class ChangeLookAtTarget : MonoBehaviour
    {
        public Transform target;
        
        private void Start()
        {
            if (target != null) return;

            target = gameObject.transform;
            Debug.Log("Target não especificado no ChangeLookAtTarget, " +
                      "padronizando para o próprio objeto.");
        }

        private void OnMouseDown()
        {
            LookAtTarget.Target = target;

            if (Camera.main == null) return;
            var fieldOfView = 60 * target.transform.localScale.x;
            Camera.main.fieldOfView = Mathf.Clamp(fieldOfView, 10, 100);
        }
    }
}
