using AbstractFactory.Enums;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory;
public class FoodFactory
{
    BurgerFactory BurgerFactory;
    PizzaFactory PizzaFactory;

   public FoodFactory()
   {
      BurgerFactory= new BurgerFactory();
      PizzaFactory= new PizzaFactory();
   }
    public IBurger? GetBurger(BurgersEnum burgersEnum)
    {
        return BurgerFactory.GetBurger(burgersEnum);
    }
    public IPizza? GetPizza(PizzasEnum pizzasEnum)
    {
        return PizzaFactory.GetPizza(pizzasEnum);
    }


}
