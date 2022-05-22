using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour //https://youtu.be/4I0vonyqMi8?t=296 Este vid nos puede facilitar la existencia para organizar. < EL VOLUMEN
{
    public static GameManager instance; //Creo buena idea que cada manager sea un singleton. Se cae de madura q no vamos a tener 2 managers iguales en ningun momento. EL VOLUMEN
    public GameState state;
    public static event Action<GameState> OnGameStateChange;


    UIManager _uiManager;
    UnitPlacer _placer;

    [SerializeField] int _coins;
    [SerializeField] List<UnitData> _levelUnits;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        UpdateGameState(GameState.Deployment);

        _placer = GetComponent<UnitPlacer>(); //quiza deberia ir esta logica en un "DeploymentManager" que se ocupe de la logica de placear unidades
        _placer.UnitPlaced += UnitPlaced;     //osea subscribir un manager que se encargue de placear unidades al evento de OnGameStateChangey
                                              //y que haga estas tareas cuando le corresponda el state, cuando las termine (player esta conforme con las unidades q coloco y toca boton de ready
                                              //se tira un GameManager.instance.ChangeGameState(Gamestate.PlayerTurn); lo cual se ataja aca de nuevo y en algun manager q se ocupe de la logica de pelea
                                              //EL VOLUMEN
        _uiManager = GetComponent<UIManager>();
        _uiManager.SetMapUnits(_levelUnits);
        _uiManager.UpdateCoins(_coins);
    }

    public void UpdateGameState(GameState newState)
    {
        state = newState;
        switch(newState)
        {
            case GameState.Deployment:
                HandleDeployment();
                break;
            case GameState.PlayerTurn:
                HandlePlayerTurn();
                break;
            case GameState.EnemyTurn:
                HandleEnemyTurn();
                break;
            case GameState.BattleEnd:
                HandleBattleEnd();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        //notificar con eventos a la script que le corresponda al cambiar los states
        OnGameStateChange?.Invoke(newState); //El "?.invoke" es para que no tire null error si nadie se subscribio al evento. Lo anoto xq no lo sabia y ni idea uds
    }

    private void HandleDeployment()
    {

    }
    private void HandlePlayerTurn()
    {

    }
    private void HandleEnemyTurn()
    {

    }
    private void HandleBattleEnd()
    {

    }
    public enum GameState
    {
        //Menus previos irian aca, pero x ahora esto es lo que hay. < EL VOLUMEN
        Deployment,
        PlayerTurn,
        EnemyTurn,
        BattleEnd
    }


    //quiza deberia ir en un manager de unidades, dejar el GameManager unicamente para flow logico de estados del juego
    //(turno nuestro, enemigo, fase de batalla, victoria/derrota, etc) EL VOLUMEN
    void UnitPlaced(UnitData data)  
    {
        _coins -= data.Cost;
        _uiManager.UpdateCoins(_coins);
    }

    
}
