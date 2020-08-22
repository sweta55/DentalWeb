	
$(document).ready(function()    {
	$('#main').hide().delay(1000).fadeIn(500);
});
function yes() {
	if(iform.elements['nm'].value!='' && iform.elements['pwd'].value!='' ){
		window.alert("Thankyou");
	}else{
		window.alert("Please fill the field");
	}
}
function no(){
	if (iform.elements['nm'].value =='' || iform.elements['pwd'].value =='' ) {
		window.alert('Please fill the field');
	}else{
		iform.elements['nm'].value ='';
		iform.elements['pwd'].value ='';
	}
} 
function subclick(){
		//	var a = hform.elements['nam'].value ;
		var a= document.getElementById('nam').value;
		var b = hform.elements['unm'].value ;
		var d = hform.elements['em'].value ;
		var e = hform.elements['txt'].value ;
		//var f = .isInteger(c);
		//console.log(f);
		var mm = document.getElementById('male').checked;
		var mf = document.getElementById('female').checked;
		var mo = document.getElementById('others').checked;
		if(a=='' ){
			document.getElementById('spnm').style.display = 'block';
			console.log('Full Name error');
		}
		if (b=='') {
			document.getElementById('spunm').style.display ='block';
			document.getElementById('spunm').innerHTML ='Please enter your address';
			console.log('Username Error');
		}else{
			document.getElementById('spunm').style.display ='none';
		}

		if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(hform.em.value)==true)
		{
			document.getElementById('spem').style.display ='none';
		}else{
			document.getElementById('spem').style.display ='block';
			document.getElementById('spem').innerHTML ='Please enter an valid email address(example:something@yahoo.com)';
		}

		if((mm || mf || mo) == false){
			console.log('Email');
			document.getElementById('spg').style.display ='block';
			document.getElementById('spg').innerHTML ='Please select your gender';
		}else{
			document.getElementById('spg').style.display ='none';
        }
	}
	function reclick(){
		document.getElementById('nam').value='';
		document.getElementById('unm').value='';
		document.getElementById('pw').value='';
		document.getElementById('em').value='';
		document.getElementById('txt').value='';
		document.getElementById('male').checked=false;
		document.getElementById('female').checked=false;
		document.getElementById('others').checked=false;
		if(document.getElementById('nam').value=='' || 
			document.getElementById('unm').value=='' || 
			document.getElementById('pw').value=='' ||
			document.getElementById('em').value=='' || 
			document.getElementById('txt').value=='' || 
			document.getElementById('male').checked==false ||
			document.getElementById('female').checked==false ||
			document.getElementById('others').checked==false){
			window.alert("Fill the field");
	}

}