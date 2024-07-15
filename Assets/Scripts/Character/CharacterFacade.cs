using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFacade : MonoBehaviour
{
    public Character _character;
    private List<ICharacterModule> _modules = new List<ICharacterModule>();
    [SerializeField]
    private CharacterConfig _config;

    void Start()
    {
        _character = new Character(transform);
        InitModules();
        Debug.Log("Стартуем");
    }


    private void InitModules()
    {
        foreach (var moduleTypeName in _config.moduleTypes)
        {
            Type moduleType = Type.GetType(moduleTypeName);
            if (moduleType != null && typeof(ICharacterModule).IsAssignableFrom(moduleType))
            {
                var module = (ICharacterModule)gameObject.AddComponent(moduleType);
                AddModule(module);
            }
        }
    }
    public void AddModule(ICharacterModule module)
    {
        _modules.Add(module);
        module.SetCharacter(_character);
    }

    void Update()
    {
        foreach (var module in _modules)
            module.UpdateModule();
    }
}
