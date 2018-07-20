
function orderFunction() {
  
    
    'use strict';
    var ordered = "<h4>Your order has been placed!</h4>";
    var total = 0.00;
    var sizeTotal = 0.00;
    var sizeArray = document.getElementsByClassName("size");
    
    //var sauceArray = document.getElementsByClassName("sauce");
    
    //var veggieArray = document.getElementsByClassName("veggies");
   

    for (var i=0; i < sizeArray.length; i++){
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
           
        }


    }
    if (selectedSize === "Personal"){
        sizeTotal = 6.00;
    } else if (selectedSize === "Medium"){
        sizeTotal = 10.00;
    } else if (selectedSize === "Large"){
        sizeTotal = 14.00;
    } else if (selectedSize === "Extra Large"){
        sizeTotal = 16.00;
    }
    total = sizeTotal;
    //console.log(selectedSize+" = $"+sizeTotal+".00"); 
    //console.log("size ordered: "+ordered); 
    //console.log("subtotal: $"+total+".00");
  
     ordered = ordered+"<h5>You Ordered: </h5>"+"A "+selectedSize+" Size Pizza, "+"$"+sizeTotal+"<br>";
    
    getCrust(total,ordered);
    //console.log(total,ordered); /*All needed infor to pass along. */
};

function getCrust(total,ordered){
    var crustTotal = 0.00;
    var crustArray = document.getElementsByClassName("crust");
    
    for (var c = 0; c < crustArray.length; c++){
        if (crustArray[c].checked){
            var selectedCrust = crustArray[c].value;
            
        }
    }
  /*  if (selectedCrust === "Plain"){
        crustTotal = 0;
    } else if (selectedCrust === "Garlic"){
        crustTotal = 0;
    } else if (selectedCrust === "Stuffed"){
        crustTotal = 3;
    } else if (selectedCrust === "Spicy"){
        crustTotal = 0;
    } else if (selectedCrust === "House"){
        crustTotal = 0;
    }
    
    */
     if (selectedCrust === "Stuffed"){
        crustTotal = 3;
    } else{
        crustTotal = 0;
    }
    
    ordered = ordered + "With "+ selectedCrust + " Crust, $"+crustTotal+"<br>";
    total = (total + crustTotal);
    
    getCheese(total, ordered);
   // console.log(crustTotal);
}


function getCheese(total, ordered){
    var cheeseTotal = 0.00;
    var cheeseArray = document.getElementsByClassName("cheese");
    
    for (var z = 0; z < cheeseArray.length; z++){
        if (cheeseArray[z].checked){
            var selectedCheese = cheeseArray[z].value;
            
        }
    }
    
    if (selectedCheese === "Extra"){
        cheeseTotal = 3;
    } else {
        cheeseTotal = 0;
    }
    total = (total + cheeseTotal);
    
    ordered = ordered + selectedCheese + " Cheese, $"+cheeseTotal+"<br>";
    
    
    getSauce(total, ordered);
}


function getSauce(total, ordered) {
    var sauceArray = document.getElementsByClassName("sauce");
    
    for (var s = 0; s < sauceArray.length; s++){
        if (sauceArray[s].checked){
            var selectedSauce = sauceArray[s].value;
            var sauceTotal= 0;
            ordered = ordered + "and "+ selectedSauce + " Sauce $0.<h6>With:</h6>";
        }
    }
    
    getMeat(total, ordered);
}


function getMeat(total, ordered){
    var meatTotal = 0;
    var selectedMeat = [];
    var meatArray = document.getElementsByClassName("meat");
    
    for (var m = 0; m < meatArray.length; m++){
        if (meatArray[m].checked) {
            selectedMeat.push(meatArray[m].value);
            //console.log("Selected meat item: ("+meatArray[m].value+")");
            ordered =ordered+meatArray[m].value+"<br>";
        }
    }
    var meatCount = selectedMeat.length;
    if (meatCount > 1) {
        meatTotal=(meatCount - 1);
    } else {
        meatTotal = 0;
    }
    total = (total+meatTotal);
   ordered = ordered+"<p class='lo'>Meat Total: $" +meatTotal+"</p><br>";
    getVeggie(total, ordered);
    }
    
function getVeggie(total, ordered){
    var veggieTotal = 0.00;
    var selectedVeggies = [];
    var veggieArray = document.getElementsByClassName("veggies");
    
    for (var v = 0; v < veggieArray.length; v++){
        if (veggieArray[v].checked) {
            selectedVeggies.push(veggieArray[v].value);
            ordered = ordered + veggieArray[v].value+"<br>";
        }
    }
    
    var veggieCount = selectedVeggies.length;
    if (veggieCount > 1){
        veggieTotal = (veggieCount - 1);
    } else{
        veggieTotal = 0;
    }
    
    total = (total + veggieTotal);
    ordered = ordered+"<p class='lo'>Veggie Total: $" +veggieTotal+"</h7>";
    document.getElementById("finish1").innerHTML = ordered;
    document.getElementById("finish2").innerHTML = "<h3>Total: <strong>$"+total+".00"+"</strong></h3>"
}


