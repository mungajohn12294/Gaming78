using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 20f;
    public float range = 80f;
    public Camera cam;
    
    public void Fire()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2));
        if (Physics.Raycast(ray, out RaycastHit hit, range))
        {
            Health h = hit.transform.GetComponent<Health>();
            if (h != null)
                h.TakeDamage(damage);
        }
    }
}
