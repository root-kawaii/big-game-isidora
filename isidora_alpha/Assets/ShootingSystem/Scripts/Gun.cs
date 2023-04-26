using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private  GameObject startingShootObject;
    [SerializeField] private GunScriptableObject gun;
    [SerializeField] private ParticleSystem ShootEffect;
    private StarterAssets.StarterAssetsInputs _playerInputs;
    //To see if It's ok to manage It like this;
    private Transform _parentTransform;
    private float _nextTimeToFire = 0f;
    

    
    void Awake()
    {
        _playerInputs = GetComponentInParent<StarterAssets.StarterAssetsInputs>();
        _parentTransform = transform.parent;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerInputs.fire && Time.time >= _nextTimeToFire){
            _nextTimeToFire = Time.time + 1f/gun.FireRate;
            Shoot();
        }
        
        //Debug reasons
        //Debug.DrawRay(_parentTransform.transform.position,_parentTransform.transform.forward,Color.red);
        
    }

    void Shoot(){

        ShootEffect.Play();
        RaycastHit hit;
        if(Physics.Raycast(startingShootObject.transform.position,startingShootObject.transform.forward,out hit,gun.Range)){
            Debug.Log(hit.transform.name);

            /*
            Need to create an object here 

            Target target = hit.transform.GetComponent<Bla>();
            if(target != null){
                fairoba
            }
            */

            //We put force on the object if it has a rigidbody

            if(hit.rigidbody != null){
                hit.rigidbody.AddForce(-hit.normal * gun.ImpactForce);
            }

            GameObject ImpactToDestroy = Instantiate(gun.ImpactEffect,hit.point,Quaternion.LookRotation(hit.normal));
            Destroy(ImpactToDestroy,2f);
        }
    }
}
