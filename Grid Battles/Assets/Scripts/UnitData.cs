using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Unit")]
public class UnitData : ScriptableObject
{
    [SerializeField] string _name;
    [SerializeField] int _hpMax;
    [SerializeField] int _damage;
    [SerializeField] int _collisionDamage;
    [SerializeField] int _defense;//just in case ELVOLUMEN
    [SerializeField] int _cost;
    [SerializeField] GameObject _prefab;
    [SerializeField] Sprite _sprite;
    [SerializeField] GameObject _instantiateParticles;
    [SerializeField] GameObject _dieParticles;
    [SerializeField] GameObject _projectile;

    public string Name { get => _name; set => _name = value; }
    public int HpMax { get => _hpMax; set => _hpMax = value; }
    public int Damage { get => _damage; set => _damage = value; }
    public int CollisionDamage { get => _collisionDamage; set => _collisionDamage = value; }
    public int Defense { get => _defense; set => _defense = value; }
    public int Cost { get => _cost; set => _cost = value; }
    public Sprite Sprite { get => _sprite; set => _sprite = value; }
    public GameObject InstantiateParticles { get => _instantiateParticles; set => _instantiateParticles = value; }
    public GameObject DieParticles { get => _dieParticles; set => _dieParticles = value; }
    public GameObject Projectile { get => _projectile; set => _projectile = value; }
    public GameObject Prefab { get => _prefab; set => _prefab = value; }
}
