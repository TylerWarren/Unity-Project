using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public class MySo : ScriptableObject 
{   
    public float value;
    
    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num)
    {
        value += num;
    }
}