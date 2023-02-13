using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineWeapon : MonoBehaviour
{
   private Transform _TargetEnemyPosition;
   private Enemy _TargetEnemy;
   private string _TargetTag;
   [SerializeField] private GameObject _mainObject;

   [Header("Health Settings")] 
   public float _entryHealth = 100;
   public float _currentHealth;
   public Image _healthBar;
   public GameObject _damageEffect;
   public GameObject _Radar;
   private bool _isDead = false;
   
   [Header("Shots Settings")]
   public float _Range = 15f;
   public float _fireRate = 1f;
   public float _rotationSpeed = 10f;


}
