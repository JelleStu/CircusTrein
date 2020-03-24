using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Circustrein
{
    class Wagons
    {
        private string returnmessage;
        private List<Wagon> wagonList = new List<Wagon>();

        public Wagons()
        {
            wagonList.Add(new Wagon(wagonList.Count + 1));
        }

        public string ReturnAnimalsFromWagons()
        {
            foreach (var wagon in wagonList.ToList())
            {
                returnmessage += "wagon " + wagon.ReturnWagonNumber() + " :" + wagon.ReturnAnimalsInWagon() + " " +
                                 "size remaining: " + wagon.ReturnSize() + " \r\n";
            }

            return returnmessage;
        }

        public void AddAnimal(Animal animal)
        {
            Wagon availableWagon = null;
            foreach (Wagon w in wagonList)
            {
                if (w.CanAddAnimal(animal))
                {
                    availableWagon = w;
                    availableWagon?.Add(animal);
                    break;
                }
                availableWagon = new Wagon(wagonList.Count + 1);

            }
            availableWagon?.Add(animal);
        }









        //    public void AddAnimalToWagon(Animal _animal)
        //    {
        //       Wagon availableWagon = GetAvailableWagon(_animal);
        //       if (_animal.IsBigFleshEater() == true)
        //       {
        //           availableWagon.BigFleshEaterInWagon();
        //       }
        //       if (_animal.IsHerbivoor() == false)
        //       {
        //           availableWagon.SetFleshEater();
        //       }
        //       availableWagon.addAnimalToWagon(_animal);

        //    }

        //    public Wagon GetAvailableWagon(Animal _animal)
        //    {
        //        foreach (var wagon in wagonList)
        //        {
        //            if (!wagon.HasBigFleshEater())
        //            {
        //                if (_animal.IsBigFleshEater() != false) continue;
        //                if (_animal.IsHerbivoor() == true)
        //                {
        //                    if (wagon.WagonCheckFleshEater() == true && _animal.GetSize() > wagon.SizeFleshEater())
        //                    {
        //                        if (wagon.ReturnSize() > 0)
        //                        {
        //                            int wagonspace = wagon.ReturnSize();
        //                            wagonspace -=_animal.GetSize();
        //                            if (wagonspace > 0)
        //                            {
        //                                return wagon;
        //                            }
        //                            else
        //                            {
        //                                continue;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            continue;
        //                        }
        //                    }
        //                    else if (wagon.WagonCheckFleshEater() == false)
        //                    {
        //                        if (wagon.ReturnSize() > 0)
        //                        {
        //                            int wagonspace = wagon.ReturnSize();
        //                            wagonspace -= _animal.GetSize();
        //                            if (wagonspace > 0)
        //                            {
        //                                return wagon;
        //                            }
        //                            else
        //                            {
        //                                continue;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            continue;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //                else
        //                {
        //                    if (wagon.WagonCheckFleshEater() == false)
        //                    {
        //                        if (_animal.GetSize() < wagon.SmallestHerbivor())
        //                        {
        //                            if (wagon.ReturnSize() > 0)
        //                            {
        //                                int wagonspace = wagon.ReturnSize();
        //                                wagonspace -= _animal.GetSize();
        //                                if (wagonspace > 0)
        //                                {
        //                                    return wagon;
        //                                }
        //                                else
        //                                {
        //                                    continue;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                continue;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            continue;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }

        //                }
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //        Wagon newWagon = new Wagon(wagonList.Count + 1);
        //        wagonList.Add(newWagon);
        //        return newWagon;
        //    }

        //}
    }
}
