using UnityEngine;

namespace SolarSystem
{
    public class LookAtTarget : MonoBehaviour
    {
        public static Transform Target;
        
        private void Start()
        {
            if (Target != null) return;

            Target = gameObject.transform;
            Debug.Log("Target não especificado no LookAtTarget, " +
                      "padronizando para o próprio objeto.");
        }

        private void Update()
        {
            if (Target)
            {
                transform.LookAt(Target);
            }
        }
    }
}
