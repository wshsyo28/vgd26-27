using UnityEngine;

public class minesweeper : MonoBehaviour
{

  [SerializedField] private int extra;
  [SerializedField] private int tiles;
  [SerializedField] private int mines;
  
  public int mineRows;
  public int mineColumns;
  public int mineFairness;

  private scripObj vardata;
  
  void Start(){
    tiles = (mineRows*extra)*(mineColumns*extra);
    mines = tiles/mineFairness - extra*mineFairness;
  }

  void Update(){
    
  }
  
}
