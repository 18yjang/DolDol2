using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldDataOld : FieldDataBase
{
  public int[,] FieldMap;
  public int IndexI = 0;
  public int IndexJ = 0;

  public FieldDataOld()
  {

  }
  public FieldDataOld(string stage)
  {
    if (stage == "0")
    {
      FieldMap = new int[,]
      {
            {2, 2, 2, 2, 2},
            {2, 6, ' ', ' ', 2},
            {2, ' ', ' ', ' ', 2},
            {2, ' ', 0, 1, 2},
            {2, 2, 2, 2, 2},
      };
      IndexI = 1;
      IndexJ = 1;
    }
    else if (stage == "1")
    {
      FieldMap = new int[,]
      {
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', 2, ' ', ' ', ' ', ' ', ' '},
            {5, 5, 5, ' ', 2, ' ', ' ', ' ', ' ', ' '},
            {4, ' ', 0, 2, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 6, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {2, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {2, ' ', 1, ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
      };
      IndexI = 2;
      IndexJ = 2;
    }
    else if (stage == "2")
    {
      FieldMap = new int[,]
      {
            {2, ' ', 4, 4, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 6, ' ', ' ', 2, ' ', ' ', ' ', ' ', ' '},
            {2, 6, ' ', ' ', 2, ' ', ' ', ' ', ' ', ' '},
            {2, ' ', ' ', 1, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 3, 3, 3, 2, ' ', ' ', ' ', ' ', ' '},
            {2, ' ', ' ', ' ', 2, ' ', ' ', ' ', ' ', ' '},
            {2, 3, 3, 3, 2, ' ', ' ', ' ', ' ', ' '},
            {2, ' ', ' ', 0, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
      };
      IndexI = 2;
      IndexJ = 2;
    }
    else if (stage == "3")
    {
      FieldMap = new int[,]
      {
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 5, ' ', ' ', ' ', ' ', 0, ' ', ' ', ' ', ' ', ' ', 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2},

            {2, 2, ' ', 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, ' ', 2, 2, 2, 2, 2, 2, 2, 2, 4, 4, 4, 2},
            {2, 6, ' ', ' ', 5, ' ', ' ', ' ', 2, 2, 2, ' ', ' ', ' ', 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, ' ', ' ', ' ', 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, ' ', 5, 1, 2}
      };

      IndexI = 2;
      IndexJ = 3;
    }
    else if (stage == "4")
    {
      FieldMap = new int[,]
      {
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2},

            {2, 4, ' ', 4, 1, 5, 2, ' ', 2, 6},
            {2, 4, ' ', 2, 2, 2, 2, ' ', 2, 2},
            {2, 4, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {2, 4, ' ', ' ', ' ', 2, 2, ' ', ' ', 5},
            {2, 2, 2, 2, 2, 2, 2, ' ', 3, 3},

            {4, 4, 4, 4, 4, ' ', ' ', ' ', ' ', ' '},
            {4, ' ', ' ', ' ', ' ', ' ', ' ', ' ', 3, 3},
            {4, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {4, ' ', ' ', ' ', ' ', ' ', ' ', 3, 3, ' '},
            {4, ' ', ' ', ' ', 0, ' ', ' ', ' ', ' ', ' '},

            {2, 2, 2, 2, 2, ' ', 3, 3, ' ', ' '},
            {2, 2, 2, 2, 2, ' ', ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, 4, ' ', ' ', ' ', ' '},
            {2, 2, 2, 2, 2, 2, 4, 4, 4, 4},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}
      };

      IndexI = 4;
      IndexJ = 2;
    }
    else if (stage == "5")
    {
      FieldMap = new int[,]
      {
                {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
                {2,' ',' ',' ',2,2,3,5,3,2,' ',' ',' ',2,2,' ',' ',' ',' ',2},
                {2,' ',' ',' ',' ',' ',' ',3,1,3,' ',' ',' ',' ',' ',' ',' ', 3,' ',2},
                {2,6,' ',' ',' ',' ',3,1,3,' ',' ',' ',' ',' ',' ',' ',' ', 3,' ',2},
                {2,2,2,2,2,2,3,2,5,2,2,2,2,2,2,2,2,' ',2,2},

                {' ',' ',' ',' ',' ',2,2,2,2,2,2,2,' ',2,2,2,2,' ',2,2},
                {' ',' ',' ',' ',' ',2,' ',' ',3,' ',' ',' ',' ',2,2,' ',' ',' ',' ',2},
                {' ',' ',' ',' ',' ',2,0,' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',3,' ',2},
                {' ',' ',' ',' ',' ',2,2,4,3,' ',4,4,4,4,2,2,' ',' ',' ',2},
                {' ',' ',' ',' ',' ',2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},

                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', 2, 2, 5, ' ', 2},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', 2, 2, 3, ' ', 2},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', 2, 2, 4, 4, 2},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', 2, 2, 2, 2, 2},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', 2, 2, 2, 2, 2}
      };

      IndexI = 3;
      IndexJ = 4;
    }
  }

  public override int[,] GetPartialMap(int indexI, int indexJ)
  {
    int[,] resultMap = new int[7, 7];

    if (indexI >= IndexI || indexJ >= IndexJ)
    {
      return null;
    }

    int intervalI = indexI * 5;
    int intervalJ = indexJ * 5;

    for (int i = 1; i <= 5; i++)
    {
      for (int j = 1; j <= 5; j++)
      {
        resultMap[i, j] = FieldMap[i - 1 + intervalI, j - 1 + intervalJ];
      }
    }

    return resultMap;
  }
}