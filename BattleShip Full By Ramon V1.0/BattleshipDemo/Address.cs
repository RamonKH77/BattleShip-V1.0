using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipDemo
{




    //Class Ship start
    public class Ship
    {
        public int ShipLength;//max 4
        public string ShipName;
        public int ShipsCount;//ships count


        public void SetArgs(int shplngth, string shpnm)
        {
            ShipName = shpnm;
            ShipLength = shplngth;
        }
    }
    //Class Ship end

    //Coordinates Class Start
    public class Coordinates
    {
        List<int> AllCoordinates = new List<int>();//all coordinates will be there. it contains all of the coordinates
        List<Ship> ShipList = new List<Ship>//List for ship names and lengths
        {
                new Ship()
                {
                    ShipName="Battleship",
                    ShipLength=4,
                    ShipsCount=1
                },
                new Ship()
                {
                    ShipName="Cruiser",
                    ShipLength=3,
                    ShipsCount=2
                },
                new Ship()
                {
                    ShipName="Destroyer",
                    ShipLength=2,
                    ShipsCount=3
                },
                new Ship()
                {
                    ShipName="Submarine",
                    ShipLength=1,
                    ShipsCount=4
                }

        };//end of Ship List
        public Coordinates()
        {
            

            foreach (var s in ShipList)
            {

                for (int i = 0; i < s.ShipsCount; i++)//Count of ships
                {
                    bool shipCountPlus = false;//bool for i++ in line 76
                    Random Start = new Random();
                    Random Chose = new Random();


                    while (shipCountPlus == false)
                    {

                        int StartRow = Start.Next(0, 9);//Starting X Coordinates;
                        int StartColumn = Start.Next(0, 9);//Starting Y Coordinates;
                        int StartCoordinate = int.Parse(StartRow.ToString() + StartColumn.ToString());//Starting X or Y Coordinates;                                                                                                      //Starting X or Y Coordinates;
                        int VerOrHor = Chose.Next(0, 1);//It makes randomly veritical or horizontal ship coordinates;
                        int CoordinateCount = StartCoordinate;//it was c1 or coordinates' count like star=1 end = 4; start+=1;


                      
                        if (VerOrHor == 0 && (StartRow + s.ShipLength) < 10)//0=Veritical Coordinate
                        {

                            List<int> WhileList = new List<int>();
                            int l = 0;
                            for (int t = 0; t < s.ShipLength; t++)
                            {
                                l = CoordinateCount++;
                                if (AllCoordinates.Contains(l)) break;
                                WhileList.Add(l);

                            }
                            if (!AllCoordinates.Contains(l))
                            {
                                shipCountPlus = true;
                                AllCoordinates.AddRange(WhileList);
                            }

                        }//End of Veritical If
                        else if (VerOrHor == 1 && StartColumn + s.ShipLength < 10)
                        {
                            List<int> WhileList = new List<int>();
                            int l = 0;
                            for (int t = 0; t < s.ShipLength; t++)
                            {
                                l = CoordinateCount += 10;//rows=10 if it's on the 3rd , next one'll be on 13.
                                if (AllCoordinates.Contains(l)) break;
                                WhileList.Add(CoordinateCount);

                            }
                            if (!AllCoordinates.Contains(l))
                            {

                                shipCountPlus = true;
                                AllCoordinates.AddRange(WhileList);
                            }

                        }//end of horizontal if


                    }//end of while


                }//End of for



            }//End of Foreach



        }//end of coordinate

        public List<int> GetList()
        {
            return AllCoordinates;
        }
    }//end of Coordinates class

}
