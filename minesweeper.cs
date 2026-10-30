using UnityEngine;

public class minesweeper : MonoBehaviour
{

  [SerializedField] private int extra;
  [SerializedField] private int tiles;
  [SerializedField] private int mines;

  public bool mineSquare;
  public int mineRows;
  public int mineColumns;
  public int mineFairness;

  private scripObj vardata;
  
  void Start(){

    if(mineRows == 0 || null){
      mineRows = 14;
    }
    if(mineSquare == true){
      mineColumns = mineRows;
    }
    
    tiles = (mineRows*extra)*(mineColumns*extra);
    mines = tiles/mineFairness - extra*mineFairness;
  }

  void Update(){
    
  }
  
}
