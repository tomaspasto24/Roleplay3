using System;
using System.Collections.Generic;

namespace Library
{

    /// <summary>
    /// Se crea la interfaz para cumplir con el patrón Polimorfismo ya que todos los personajes implementan unos mismos métodos en común.
    /// Antes había una sobrecarga de AttackEnemy (4 métodos) y ahora al tener una interfaz en común solo hace falta un método.
    /// </summary>
    public interface ICharacter
    {
        void RecieveDamage(int damage);
        void AttackEnemy(ICharacter enemyToAtack);
        void EquipItem(Item item);
        void UnequipItem(Item item);
        int ReturnArmor();
        string ReturnName();
        int ReturnAttack();
        int CurrentHealth();
        void RestoreHealth();
        List<Item> ReturnInventory();
    }
}

