using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Character/Config")]
public class CharacterConfig : ScriptableObject
{
    public List<string> moduleTypes;
}
