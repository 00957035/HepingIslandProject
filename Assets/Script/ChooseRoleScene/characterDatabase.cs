using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class characterDatabase : ScriptableObject
{
    public character[] role;

    public int CharacterCount
    {
        get
        {
            return role.Length;
        }
    }
    public character GetCharactor(int index)
    {
        return role[index];
    }
}
