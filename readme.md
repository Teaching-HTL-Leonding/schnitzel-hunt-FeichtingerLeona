# Schnitzel Hunt

![Schnitzels](./hero-image.png)

## Introduction

You love to order food at local restaurants. There are 50 restaurants in your city, so you have a lot of choices. Luckily, all restaurants offer their menu card in a standardized, digital form. Here is an example from one of your favorite restaurants *Café Cobalt*:

```txt
APPETIZERS

Baked Clams: 9€
Quesadilla: 10€
Guacamole: 5€

MAIN DISHES

Schnitzel: 14€
Chicken Parmesan: 9€
Grilled Chicken: 11€
Fried Rice: 10€

DESSERTS

Creme Brulee: 5€
Lemon Tart: 4€
Cheesecake: 3€
Raspberry Sorbet: 6€
```

You downloaded all menu cards. They are available in [MenuCards.zip](./MenuCards.zip). You decide to write a program that helps you finding exactly the right dishes for the right circumstances. Did I mention that you love Schnitzel? So all your programs are about finding the right Schnitzel.

## Basic Requirements

* Extract all menu cards from the zip file and store them in a separate folder. The folder must only contain the menu cards.
* Write a program that uses [`Directory.GetFiles`](https://learn.microsoft.com/en-us/dotnet/api/system.io.directory.getfiles)` to get all menu cards from the folder.
* Print the names of all restaurants (the file names without the extension) that have Schnitzel on the menu on the console. Note that all kinds of Schnitzel dishes count. So if a restaurant has *Schnitzel Burger* or something similar, it should count as well.
* After each restaurant name, you have to print the names of the Schnitzel dishes that are offered by the restaurant. If a restaurant offers multiple Schnitzel dishes, you have to print all of them.
* You do not need to create methods for the basic requirements. Focus on file and string handling. However, if you want to create methods, feel free to do so!

Example output:

```txt
WHERE TO GET SCHNITZEL?
=======================

Ziti Zebra
    Schnitzel Miniburger
Jalapeno Jaguar
    Schnitzel Miniburger
    Schnitzel
    Sweet Schnitzel Surprise
Taco Twilight
    Schnitzel
Ribs Rainbow
    Schnitzel Miniburger
Sushi Starfish
    Schnitzel Miniburger
Delicatessen Dandelion
    Schnitzel Miniburger
Omelette Octopus
    Schnitzel Miniburger
Gelato Gazebo
    Schnitzel Miniburger
Burger Bloom
    Schnitzel Miniburger
    Sweet Schnitzel Surprise
Brasserie Bumblebee
    Seitan Schnitzel
The Cheesy Spoon
    Seitan Schnitzel
Pancake Panther
    Seitan Schnitzel
Barbecue Bonsai
    Schnitzel
Bistro Blossom
    Schnitzel
Tart Tangerine
    Schnitzel Miniburger
    Schnitzel
Salad Seahorse
    Schnitzel Miniburger
    Seitan Schnitzel
Vegan Viper
    Schnitzel
    Seitan Schnitzel
    Sweet Schnitzel Surprise
Diner Drizzle
    Seitan Schnitzel
Café Cobalt
    Schnitzel
Pizzeria Petal
    Seitan Schnitzel
Chopsticks Chimera
    Schnitzel
Dumpling Dragonfly
    Seitan Schnitzel
Pasta Peony
    Schnitzel Miniburger
Yogurt Yeti
    Schnitzel
Udon Unicorn
    Schnitzel Miniburger
Fondue Fox
    Schnitzel Miniburger
    Schnitzel
    Sweet Schnitzel Surprise
Steak Sunshine
    Seitan Schnitzel
Grill Glacier
    Schnitzel
    Sweet Schnitzel Surprise
Noodle Nebula
    Schnitzel Miniburger
Bamboo Bison
    Schnitzel
Kebab Koala
    Seitan Schnitzel
Wok Walrus
    Schnitzel
    Sweet Schnitzel Surprise
Macaroni Macaw
    Schnitzel
    Seitan Schnitzel
    Sweet Schnitzel Surprise
Quiche Quokka
    Seitan Schnitzel
Fajita Flamingo
    Schnitzel Miniburger
    Seitan Schnitzel
```

## Advanced Requirements

* In addition to the output above, you want to know where to get the cheapest *Seitan Schnitzel* (exactly that dish name, no other kind of Schnitzel). Print the name of the restaurant and the price of the *Seitan Schnitzel* on the console. Write a helper method to split menu lines into dish name and price. Example output:

    ```txt
    WHERE TO GET THE CHEAPEST SEITAN SCHNITZEL?
    ===========================================

    Diner Drizzle, 6€
    ```

* Add the same functionality for finding the most expensive *Seitan Schnitzel*. Example output:

    ```txt
    WHERE TO GET THE MOST EXPENSIVE SEITAN SCHNITZEL?
    =================================================

    Macaroni Macaw, 25€
    ```

## More Advanced Requirements

You want to have a big Schnitzel feast with Schnitzel for appetizer, Schnitzel for main dish, and Schnitzel for desert! You are willing to drive through the city and collect the dishes from different restaurants. Find the cheapest Schnitzel-related menu combination and print the name of the restaurants, the name of the dishes, the price for each dish, and the total price on the console. Example output:

```txt
WHERE TO GET THE CHEAPEST SCHNITZEL FEAST?
==========================================

Appetizers: Burger Bloom, Schnitzel Miniburger, 3€
Main Dish: Diner Drizzle, Seitan Schnitzel, 6€
Dessert: Fondue Fox, Sweet Schnitzel Surprise, 3€
```
