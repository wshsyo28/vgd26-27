using UnityEngine;

public class minesweeper : MonoBehaviour
{

  [SerializedField] private int tiles;
  [SerializedField] private int mines;
  private int rows;
  private int columns;
  private int fairness;
  
  public bool mineSquare;

  private scripObj vardata;
  private int[] board;
  
  void Start(){

    rows = vardata.MineSweeperRows;
    columns = vardata.MineSweeperColumns;
    fairness = vardata.MineSweeperFairness;
    board = vardata.MineSweeperMatrix;

    if(mineRows == 0 || null){
      mineRows = 14;
    }
    if(mineSquare == true){
      mineColumns = mineRows;
    }
    
    tiles = mineRows*mineColumns;
    mines = tiles/fairness;

    
  }

  void Update(){
    
  }

  private void BoardGen()
  {
    for (x = 0; x < rows; x++)
    {
      for (y = 0; y < columns; y++)
      {
        board[x,y] = 0;
      }
    }
  }
  
}
