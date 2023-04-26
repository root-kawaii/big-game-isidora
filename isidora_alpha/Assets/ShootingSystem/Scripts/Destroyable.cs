using UnityEngine;

public class Destroyable : MonoBehaviour
{
    [SerializeField] private float health = 100f;

    //Function to call when a destroyable object takes a damage
    public void TakeDamage(float amount){
        health -= amount;
        if(health <= 0){
            BreakDestroyable();
        }
    }
    
    //Function to call when the life of the object is less then zero
    void BreakDestroyable(){
        Destroy(gameObject);
    }
}
