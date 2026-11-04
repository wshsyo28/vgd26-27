using UnityEngine;

public class minesweeper : MonoBehaviour
{

  [SerializedField] private int extra;
  [SerializedField] private int tiles;
  [SerializedField] private int mines;
  private int rows;
  private int columns;
  private int fairness;
  
  public bool mineSquare;

  private scripObj vardata;
  
  void Start(){

    rows = scripObj.MineSweeperRows;
    columns = scripObj.MineSweeperColumns;
    fairness = scripObj.MineSweeperFairness;

    if(mineRows == 0 || null){
      mineRows = 14;
    }
    if(mineSquare == true){
      mineColumns = mineRows;
    }
    
    tiles = (mineRows*extra)*(mineColumns*extra);
    mines = tiles/fairness - extra*fairness;

    
  }

  void Update(){
    
  }
  
}
