var scroll = 0;

var prevVal = 0;

var documentHeight = 0;

var showTooltip = true
var hideUnowned = false;





function searchForRecipe(){
	var input, filter, ul, li, a, i, txtValue;
	input = document.getElementById('searchBar');
	filter = input.value.toUpperCase();
	ul = document.getElementById("recipes-list");
	li = ul.getElementsByTagName('li');

	// Loop through all list items, and hide those who don't match the search query
	for (i = 0; i < li.length; i++) {
		a = li[i].getElementsByTagName("a")[0];
		txtValue = a.textContent || a.innerText;
		if (txtValue.toUpperCase().indexOf(filter) > -1) {
			li[i].style.display = "";
		} else {
			li[i].style.display = "none";
		}
	}
}





function setCookie(cname,cvalue,exdays) {
  var d = new Date();
  d.setTime(d.getTime() + (exdays*24*60*60*1000));
  var expires = "expires=" + d.toGMTString();
  document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
  var name = cname + "=";
  var decodedCookie = decodeURIComponent(document.cookie);
  var ca = decodedCookie.split(';');
  for(var i = 0; i < ca.length; i++) {
    var c = ca[i];
    while (c.charAt(0) == ' ') {
      c = c.substring(1);
    }
    if (c.indexOf(name) == 0) {
      return c.substring(name.length, c.length);
    }
  }
  return "";
}

function checkCookie() {
	var showtooltip=getCookie("showtooltip");
	var hideunowned=getCookie("hideunowned");
	
	if (showtooltip == "") {
		setCookie("showtooltip", "True", 30);
	}
	if (hideunowned == ""){
		setCookie("hideunowned", "False", 30);
	} 
}


function myRepeatFunction(item){
	console.log("XD");
}


$(document).ready(function(){


  
    $(".circles li").each(function () {
		var rndDim = Math.floor((Math.random() * 100) + 15);
		var rndPos = Math.floor((Math.random() * 85) + 5);
		var rndLeft = Math.floor((Math.random() * 85) + 10);
		var rndAnimDuration = Math.floor((Math.random() * 45) +15);
		var rndAnimDelay = Math.floor((Math.random() * 20) + 0);
		var randAlpha= Math.random();
		
		
		$(this).css("width", rndDim+"px");
		$(this).css("height", rndDim+"px");
		$(this).css("left", rndPos+"%");
		$(this).css("animation-duration", rndAnimDuration+"s");
		$(this).css("animation-delay", rndAnimDelay+"s");
		$(this).css("background-color", "rgba(126, 217, 87, "+randAlpha+")");
		
		this.addEventListener("animationiteration", function() {
			event.preventDefault();
			var rndLeft = Math.floor((Math.random() * 85) + 10);
		
			$(this).css("left", rndLeft+"%");
		});
	})


	

	checkCookie();

	var showtooltipVar = getCookie("showtooltip");
	var hideunownedVar = getCookie("hideunowned");

	if(showtooltipVar == "True"){
		showTooltip = true;
	}
	else{
		showTooltip = false;
	}

	if(hideunownedVar == "True"){
		hideUnowned = true;
	}
	else{
		hideUnowned = false;
	}


	$('.select2-form').select2({
		minimumResultsForSearch: Infinity,
		placeholder: "Jednostka miary"
	});




	

	
	documentHeight = $(document).height();
	
	$("#add-product-gray-screen").css("height", documentHeight);
	
	$(function () {
		$('[data-toggle="popover"]').popover()
	})
	
	
	if(hideUnowned){
		var child = $(".product-list").children().children(".quantity-control").children(".quantity-form").children(".quantity-counter");
		
		$("#hide-unowned-products").text("Pokaż nieposiadane produkty");
		
		
		
		$(child).each(function( index ) {
			if($(this).val() == 0){
				$(this).parent().parent().parent().toggle();
			}
		});
	}
	else{
		var child = $(".product-list").children().children(".quantity-control").children(".quantity-form").children(".quantity-counter");
		
		$("#hide-unowned-products").text("Ukryj nieposiadane produkty");
		
		
	}
	
	
	$("#hide-unowned-products").click(function(){
		var child = $(".product-list").children().children(".quantity-control").children(".quantity-form").children(".quantity-counter");
		if($(this).text() == "Pokaż nieposiadane produkty"){
			$(this).text("Ukryj nieposiadane produkty");
			setCookie("hideunowned", "False", 30);
		}
		else{
			$(this).text("Pokaż nieposiadane produkty");
			setCookie("hideunowned", "True", 30);
		}
		
		
		$(child).each(function( index ) {
			if($(this).val() == 0){
				$(this).parent().parent().parent().toggle();
			}
		});
	});





	$("#close-tooltip").click(function(){
		if ($('.control-checkbox > input').is(':checked')) {
			setCookie("showtooltip", "False", 30);
		}
		$("#tooltip-wrapper").removeClass("slide-right-tooltip");
		$("#remember-checkbox").removeClass("slide-right-tooltip");
		setTimeout(function () {
			$("#tooltip-wrapper").addClass("d-none");
			$("#remember-checkbox").addClass("d-none");
		}, 1500);
	});

	$("#add-product").click(function(){
		$("#add-product-gray-screen").toggleClass("d-flex");
		$("#add-product-adding-wrapper").toggleClass("transform-to-origin");
    });
	
	
	$(".checkmark").hover(
		function(){
			$(".close").css("box-shadow", "inset 0px 0px 0px 30px #5ED957");
		}, function(){
			$(".close").css("box-shadow", "inset 0px 0px 0px 30px #7ED957");
		}
	);
	
	$("#close-form-addproduct").click(function(){
		$("#add-product-gray-screen").toggleClass("d-flex");
		$("#add-product-adding-wrapper").toggleClass("transform-to-origin");
	});
	
	$("#add-product-gray-screen").click(function(e){
		if(e.target !== e.currentTarget) return;
		$("#add-product-adding-wrapper").toggleClass("transform-to-origin");
		$(this).toggleClass("d-flex");
	});
	

	$('.popper-below').popover({
		placement: 'bottom',
		title: '',
		content: 'Liczba nie może być ujemna.',
		sanitize: true
	});

	$('.popper-above').popover({
		placement: 'bottom',
		title: '',
		content: 'Limit osiągnięty',
		sanitize: true
	});
  
	$(".btn").mouseup(function(){
		$(this).blur();
	})

var counter = 0;

var timestamp = new Date();

var disabled = false;

$(".quantity-control > .btn").click(function(){
	counter++;
	if(timestamp - new Date() < -5000){
		timestamp = new Date();
		counter = 0
	}
	
	
	if((timestamp - new Date() < -2500)&&(counter >= 5)&&(showTooltip)){
		$("#tooltip-wrapper").addClass("slide-right-tooltip");
		$("#remember-checkbox").addClass("slide-right-tooltip");
		disabled = true;
	}
	
	
});


$("#inputCalories").keypress(function(e){
	var keyCode = e.which;
	if ( (keyCode != 8 || keyCode ==32 ) && (keyCode < 48 || keyCode > 57)) { 
      return false;
    }
});

$('#inputCalories').on('input', function() {

	var popper = $(this).siblings(".popper-above")

	if (this.value.length > this.maxLength){
		this.value = this.value.slice(0, this.maxLength); 
		popper.popover('show');
		setTimeout(function () {
			popper.popover('hide');
		}, 2000);
	}
	
	prevVal = this.value;
});

var keyCode;

$(".quantity-counter").keypress(function(e){
	keyCode = e.which;
	if ( (keyCode != 8 || keyCode ==32 ) && (keyCode < 48 || keyCode > 57)) { 
      return false;
    }
});

$('.quantity-counter').focus(function() {
	prevVal = $(this).val();
		
	if(prevVal == 0){
		this.value = "";
	}

});

$('.quantity-counter').on("focusout", function() {
	if($(this).val() == ""){
		if(prevVal == ""){
			$(this).val(0);
		}
		else{
			$(this).val(prevVal);
		}	
	}
	if($(this).val()[0] == 0){
		$(this).val(0);
	}
	
});
	

$('.quantity-counter').on("focusin", function() {
	if($(this).val() == 0){
		$(this).val("");
	}
	
});



$('.quantity-counter').on('input', function() {

	var key = parseInt(String.fromCharCode(keyCode));
	
	popper = $(this).siblings(".popper-above");

	if($(this).val()[0] == 0){
		$(this).val(key);
	}


	

	if (this.value.length > this.maxLength){
		this.value = this.value.slice(0, this.maxLength); 	
		
		
		var attr = popper.attr('aria-describedby');
		if(typeof attr === typeof undefined || attr === false){
			popper.popover('show');
			attr = popper.attr('aria-describedby');
			setTimeout(function () {
				$("#"+attr).popover('hide');
			}, 2000);	
		}
		
		
		
		
	}
	
	
	prevVal = this.value;
});

for(var i = 1; i <= 10; i++){
	randomVal = Math.floor((Math.random() * 75) + 10);
	$(".circles").children("li").eq(i).css("left", randomVal+"%");
}

var timeoutDecrement;

var decrementElement;

var popper;

$(".quantity-control > .decrement" ).mousedown(function() {
	timeoutDecrement = $(this);

	decrementElement = $(this);

	prevVal = $(this).parent().children(".quantity-form").children(".quantity-counter").val();

	popper = $(this).parent().children(".quantity-form").children(".popper-below");
	
	timeoutDecrement = setInterval(function(){
		--prevVal;
		if(prevVal < 0) prevVal = 0;
		
		decrementElement.parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
		
		
		
		if(decrementElement.parent().children(".quantity-form").children(".quantity-counter").val() < 0){
		decrementElement.parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
	}
	else{
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(--prevVal);
	}
		
    },135);
	if(prevVal < 0) prevVal = 0;
	decrementElement.parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
	
	
	
	return false;
});



$(document).mouseup(function(){
	clearInterval(timeoutDecrement);
	if(prevVal < 0) prevVal = 0;
	
	
	
	
 
	
	if($(decrementElement).parent().children(".quantity-form").children(".quantity-counter").val() == 0){
		$(decrementElement).parent().children(".quantity-form").children(".quantity-counter").val(prevVal);	
	}
	

	
	
 
    return false;
});


$(decrementElement).mouseup(function(){
	if(prevVal < 0) prevVal = 0;


	
	if($(this).parent().children(".quantity-form").children(".quantity-counter").val() == 0){
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
	}

    return false;
});






$(".quantity-control > .decrement").click(function(){
	
	
	
	popper = $(this).parent().children(".quantity-form").children(".popper-below");
	
	prevVal = $(this).parent().children(".quantity-form").children(".quantity-counter").val();
	
	
	
	
	if($(this).parent().children(".quantity-form").children(".quantity-counter").val() == 0){
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(0);
		
		var attr = popper.attr('aria-describedby');
		if(typeof attr === typeof undefined || attr === false){
			popper.popover('show');
			attr = popper.attr('aria-describedby');
			setTimeout(function () {
				$("#"+attr).popover('hide');
			}, 2000);	
		}
}
	else{
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(--prevVal);
	}
})
		
		
		
		
		
		
		
		
		
		
		
var timeoutIncrement;

var incrementElement;


$(".quantity-control > .increment" ).mousedown(function() {
	timeoutIncrement = $(this);

	incrementElement = $(this);

	popper = $(this).parent().children(".quantity-form").children(".popper-above");
	
	prevVal = $(this).parent().children(".quantity-form").children(".quantity-counter").val();
	
	timeoutIncrement = setInterval(function(){
		++prevVal;
		incrementElement.parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
		
	if(incrementElement.parent().children(".quantity-form").children(".quantity-counter").val() >= 999){
		incrementElement.parent().children(".quantity-form").children(".quantity-counter").val(999);
	}
	else{
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(++prevVal);
	}
		
    },135);
	
	incrementElement.parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
	
	
	
	return false;
});

$(document).mouseup(function(){
    clearInterval(timeoutIncrement);
	
	if(prevVal > 999) prevVal = 999;
	
	if($(incrementElement).parent().children(".quantity-form").children(".quantity-counter").val() == 999){
		$(incrementElement).parent().children(".quantity-form").children(".quantity-counter").val(prevVal);	
	}
	
    return false;
});

$(incrementElement).mouseup(function(){
	
	if(prevVal > 999) prevVal = 999;

	
	if($(this).parent().children(".quantity-form").children(".quantity-counter").val() == 999){
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(prevVal);
	}
    return false;
});



		
$(".quantity-control > .increment").click(function(){
	
	
	
	var popper = $(this).parent().children(".quantity-form").children(".popper-above");



	prevVal = $(this).parent().children(".quantity-form").children(".quantity-counter").val();


	if($(this).parent().children(".quantity-form").children(".quantity-counter").val() == 999){
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(999);
		
		var attr = popper.attr('aria-describedby');
		if(typeof attr === typeof undefined || attr === false){
			popper.popover('show');
			attr = popper.attr('aria-describedby');
			setTimeout(function () {
				$("#"+attr).popover('hide');
			}, 2000);	
		}

	}
	else{
		$(this).parent().children(".quantity-form").children(".quantity-counter").val(++prevVal);
	}
})		


	$("#button-feedback").click(function(){
		$("#message-wrapper").toggleClass("d-none");
	});
	
	$("#message-wrapper").click(function(e){
		if(e.target !== e.currentTarget) return;
		$(this).toggleClass("d-none");
	});
	
	
	
	
	
});














