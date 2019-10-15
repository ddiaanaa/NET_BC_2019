// JavaScript source code
/*document.getElementById('ok').onclick = function () {
    var name = document.getElementById('name').value;
    var age = document.getElementById('age').value;

    var text = "Your name is " + name;
    text += " and you are " + age + " years old ";

    document.getElementById('result').innerHTML = text;
    document.getElementById('ok').style.display = 'none';

};*/
$(function () {
    $("#ok").click(function () {
        var name = $("#name").val();
        var age = parseInt($("#age").val());
        age += 5;

        var text = "Your name is " + name;
        text += "and you are " + age + " years old";

        $("#result").html(text);
        $("#ok").hide();

    });
});
$(function () {
    $("#sum").click(function () {
        var number1 = parseInt($("#num1").val());
        var number2 = parseInt($("#num2").val());
        var sum = number1 + number2;            
              
        $("#sum").html(sum);       

    });
});
$(function () {
    $("#sub").click(function () {
        var number1 = parseInt($("#num1").val());
        var number2 = parseInt($("#num2").val());
       
        var sub = number1 - number2;
        
        var text = "The substraction of numbers is" + sub;

        $("#result").html(text);        
        $("#sub").hide();

    });
});

