using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.SerializableAttribute]
public class Dialogo
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
    
}
