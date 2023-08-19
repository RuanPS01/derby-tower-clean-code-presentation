///
///  
///   Limpando a nossa sintaxe e
///   uso do C# no Unity
///    
///   Referências: https://github.com/sampaiodias/unity-clean-code#the-basics
/// 
/// 
/// por Ruan Patrick


#region identação

// The code below is an example of *bad* identation.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class MyCustomScript    :  MonoBehaviour{
    //Use this for initialization
    void Start(   )
        {
    }
        // Update is called once per frame
        void Update()   { }
}

#endregion





#region tipos de nomes

// Do
public int healthAmount;
public string teamName;
// Do NOT
public int hp;
public string tName;

#endregion





#region variáveis legíveis

// Do
public int movementSpeed;
// Do NOT
public int mvmtSpeed;

#endregion





#region subistantivos apenas

// Do
public int movementSpeed;
// Do NOT
public int getMovementSpeed;

#endregion





#region "invólucro" correto

public int movementSpeed; // Public variable, Camel Case
private int _movementSpeed; // Private variable, Camel Case with optional '_' at the start
public Transform Speed { get; set; } // Property, Pascal Case
private const int MovementSpeed = 10; // Constant, Pascal Case

#endregion





#region abreviação

// Do
public string groupName;
// Do NOT
public int grpName;

// Recommended for math-related scripts, like Vector2
public int x;
public int y;

#endregion





#region use explícitamente "private"

// Do
private bool _isJumping;
// Do NOT
bool _isJumping;

#endregion





#region a declaração var

// Do
var players = new List<Players>();
// Do NOT
var players = PlayerManager.GetPlayers();

//Or do this

List<Players> players = new List<Players>()

List<Players> others_players = PlayerManager.GetPlayers();

#endregion





#region serialização

// Serialized
public int movementSpeed;
public int movementSpeed = 10;
[SerializeField] private int _movementSpeed;
[SerializeField] private int _movementSpeed = 10;
//Or
[SerializeField]
private int _movementSpeed;
[SerializeField, AnotherCoolAttribute]
private bool _isEnemy;

// NOT Serialized
private int _movementSpeed;
private int _movementSpeed = 10;
public int MovementSpeed { get; set; }

#endregion





#region métodos

// Do
public void SetInitialScore()
{

}

// Do NOT
public void InitialScore()
{

}

public void setInitialScore()
{

}

public void SetInitScr()
{

}

// and

// Do
public bool IsNewHighScore(int currentScore)
{

}

// Do NOT
public bool IsNewHighScore(int CurrentScore)
{

}

public bool IsNewHighScore(int _currentScore)
{

}

#endregion





#region linhas cumpridas

// Do

Debug.Log("This is just an example log that will print a long text with the values of the script: "
    + playerName + " " + playerHealth);

string logMessageForPlayersInformation =
    PlayerManager.GetPlayerInformation(GetPlayerIndex("Player1")) +
    PlayerManager.GetPlayerInformation(GetPlayerIndex("Player2"));
Debug.Log(logMessageForPlayersInformation);

// Do NOT

// Too long
Debug.Log("This is just an example log that will print a long text with the values of the script: " + playerName + " " + playerHealth);

string logMessageForPlayersInformation =
    PlayerManager.GetPlayerInformation(
        GetPlayerIndex("Player1")) +
    PlayerManager.GetPlayerInformation(
        GetPlayerIndex("Player2"));
Debug.Log(logMessageForPlayersInformation);

#endregion





#region complexidade

var someValue = 100;
var myValues = new int[10, 5]
for (int i = 0; i < 10; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if(i >= 1)
        {
            someValue--;
        } else
        {
            while(someValue > 50)
            {
                someValue -= 10;
            }
        }
        myValues[i, j] = someValue;
    }
}

#endregion





#region padrão de abertura de chave ou não

// Do

for(int i = 0; i < 10; i++)
    DoSomething();

if(_isJumping == false) return;

// Avoid

if(_isJumping == false) DoSomething();

// Do NOT

// Nesting multi-line statements without braces
for(int i = 0; i < 10; i++)
    for(int j = 0; j < 10; j++)
        DoSomething();

#endregion





#region namespaces

//using System;

//namespace Company.Product.Feature
//{
//    public class Example
//    {

//    }
//}

#endregion





#region comentários

//Do

/// <summary>
/// 
/// </summary>
public class Example
{

}



// Do

/// <summary>
/// Calculates the total area of a circle.
/// </summary>
/// <param name="radius">The radius of the circle</param>
private float CalculateCircleArea(float radius)
{
    return 3.14f * radius * radius;
}


//Do NOT

// Calculates the total area of a circle, given a certain radius.
private float CalculateCircleArea(float radius)
{
    return 3.14f * radius * radius;
}


//Do NOT NOT NOT!
// Do NOT! Once again, this is an example of what you should NOT do!

private void CreateEnemy(GameObject prefab)
{
    // The GameObject of the enemy to be instantiated
    GameObject enemy;
    // Creates the enemy in the scene
    enemy = Instantiate(prefab)


    enemy.GetComponent<Enemy>().InitiateMovementBehaviour(); // Makes the enemy walk around the world
}

#endregion