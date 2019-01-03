# Iron Ninja

We are going to be revisiting our **Hungry Ninja** classes and build out a few new classes using *Inheritance*, *Abstraction*, and *Interfaces*. Let's create a food competition between two classes, Ninja and Sensei, and see who can consume enough calories the quickest.


## Objectives:
* Create an abstract class for the former Ninja class and a new Sensei class.
* Build a new interface that allows Ninja and Sensei classes to consume the same foods differently.
* Add a new class called Drink that inherits from Food.


### Human.cs
Create a *Human* abstract class with the same properties the Ninja class contained.
```
// OUTLINE TO GO HERE
```

### IConsumable.cs
Create an *IConsumable* interface that contains an Eat() method. We will use this interface to distinguish the Eat method between Ninja and Sensei. Then add the interface to the Ninja class.
```
public interface IConsumable
    {
        // your code goes here
    }
```


### Drink.cs
Create a *Drink* class that inherits from the Food class. Make sure Drink objects are always sweet.




### Ninja.cs
Based on the Ninja class example below:
```
class Ninja : IConsumable
    {
        // .... your previous code for Ninja class ....

        // add a second overloaded constructor that only passes in name and calories

        public void Eat(Food item)
        {
            // when a Ninja consumes spicy food: a Drink must follow in the foodHistory chain. Console a warning that Ninja cannot continuing eating without a Drink next. 
            // Otherwise, if the succeeding Food object is not a Drink after the spicy food, console that Ninja cannot eat anymore food until a Drink. The Ninja consumes no calories and does not add the object to foodHistory.

            // if the Food is sweet and not spicy, Ninja receives 25% more calories.

            // if the Food is both sweet and spicy, Ninja consumes the food as usual.
        }

    }
```


