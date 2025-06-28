using UnityEngine;

public class DisableCollisionAfterFinish : MonoBehaviour
{
    
    [SerializeField] private string otherSphereName = "yellow";

   
    private Collider otherSphereCollider;
    
   
    private Collider myCollider;

   
    private bool hasPassedFinish = false;

    void Start()
    {
       
        myCollider = GetComponent<Collider>();
        
        
        GameObject otherSphere = GameObject.Find(otherSphereName);
        if (otherSphere != null)
        {
            otherSphereCollider = otherSphere.GetComponent<Collider>();
        }
        else
        {
            Debug.LogError("Не найдена сфера с именем: " + otherSphereName);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        
        if (!hasPassedFinish && collider.name == "FinishLine" && collider.isTrigger)
        {
           
            if (myCollider != null && otherSphereCollider != null)
            {
                Physics.IgnoreCollision(myCollider, otherSphereCollider, true);
                hasPassedFinish = true;
                Debug.Log(gameObject.name  + otherSphereCollider.gameObject.name);
            }
        }
    }
}