using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private List<string> canDamage;
    private void OnCollisionEnter(Collision col)
    {
        var tag = col.gameObject.tag;
        if (canDamage.Contains(tag))
            print("Ouch!");
    }
}
