using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Guns")]
public class GunScriptableObject : ScriptableObject
{
    public LayerMask HitMask; //HitMask to give to the raycast
    public string GunName;
    // public Sprite GunIcon;
    public Vector3 Spread = new Vector3 (0.1f,0.1f,0.1f); //Spread to give to the raycast according to precision
    public float FireRate = 0.25f;
    public float Damage = 10f;
    public float Range = 100f;
    public float ImpactForce = 10f;
    public float ReloadTime = 0f;
    public float Recoil = 0f;
    
    //public ParticleSystem ShootEffect;
    public GameObject ImpactEffect;
}
