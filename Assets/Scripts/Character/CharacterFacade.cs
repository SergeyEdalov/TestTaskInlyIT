using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFacade : MonoBehaviour
{
    public Character _character;
    private List<ICharacterModule> _modules = new List<ICharacterModule>();

    void Start()
    {
        _character = new Character(transform);
        AddDefaultModules();
        Debug.Log("Стартуем");
    }

    public void AddModule(ICharacterModule module)
    {
        _modules.Add(module);
        module.SetCharacter(_character);
    }

    private void AddDefaultModules()
    {
        AddModule(gameObject.AddComponent<MoveModule>());
        AddModule(gameObject.AddComponent<HealthPickModule>());
        AddModule(gameObject.AddComponent<DamageModule>());        
    }

    void Update()
    {
        foreach (var module in _modules)
            module.UpdateModule();
    }
}
