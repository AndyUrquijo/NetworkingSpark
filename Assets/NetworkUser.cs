using UnityEngine;
using System.Collections;

public struct NetworkUser
{
    public enum UserType { STUDENT, INSTRUCTOR };
    public UserType Type;
    public string Name;
    public string Password;
}
