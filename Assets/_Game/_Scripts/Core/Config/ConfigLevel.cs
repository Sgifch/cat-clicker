using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConfigLevel", menuName = "Config/Config level")]
public class ConfigLevel : ScriptableObject
{
    [SerializeField]
    Dictionary<int, int> level = new Dictionary<int, int>();
}
