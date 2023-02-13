using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MachineWeapon : MonoBehaviour
{
   private Transform _TargetEnemyPosition;
   private Enemy _TargetEnemy;
   public string _TargetTag;
   [SerializeField] private GameObject _mainObject;

   [Header("Health Settings")] 
   public float _entryHealth = 100;
   public float _currentHealth;
   public Image _healthBar;
   public GameObject _damageEffect;
   
   private bool _isDead = false;
   
   [Header("Shots Settings")]
   public GameObject _Radar;
   public float _Range = 15f;
   public float _fireRate = 1f;
   public float _rotationSpeed = 10f;
   public Transform _returnObject;
   private float _fireTime = 0f;
   private Vector3 _radarScale;

   private GameObject[] _Enemys;


   IEnumerator CheckTheEnvironment()
   {
      while (true)
      {
         yield return new WaitForSeconds(.5f);

         _Enemys = GameObject.FindGameObjectsWithTag(_TargetTag);

         float ShortDistance = Mathf.Infinity;
         Enemy TheNearestEnemy = null;

         foreach (GameObject Enemy in _Enemys)
         {
            float DistanceToEnemy = Vector3.Distance(transform.position, Enemy.transform.position);

            if (DistanceToEnemy < ShortDistance)
            {
               ShortDistance = DistanceToEnemy;
               TheNearestEnemy = Enemy.GetComponent<Enemy>();
            }

            if (ShortDistance != null && ShortDistance <= _Range)
            {
               _TargetEnemyPosition = TheNearestEnemy.transform;
               _TargetEnemy = TheNearestEnemy;
               
            }
            else
            {
               _TargetEnemyPosition = null;
            }
         }

      }

     
   }
   
}
