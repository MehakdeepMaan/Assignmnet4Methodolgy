function SavedData(sellerName,address,city, phone,email,make,model,year )
{
	var object = {sellerName:sellerName, address:address,city:city,phone: phone, email:email,make:make,model:model,year:year};
	
	var listOfData = localStorage.getItem("listOfData");
if(listOfData != "" && listOfData !==null)
{
	listOfData = JSON.parse(listOfData);
	
}
else{
	listOfData = [];
}

listOfData.push(object);
localStorage.setItem( "listOfData",JSON.stringify(listOfData));
newFunction( object);
};

function Readdata()
{
var listOfData = localStorage.getItem("listOfData");
if(listOfData != "" && listOfData !==null)
{
	listOfData = JSON.parse(listOfData);
	
}
else{
	listOfData = [];
}


 var data = document.getElementById("data");
for (var i= 0; i < listOfData.length; i++)
{
	var object = listOfData[i];
	data.innerHTML += "<tr><td>"+object.sellerName +" </td><td>" + object.city + " </td><td>" +
	object.address +"  </td><td>" + object.email +" </td><td>" + object.phone +" </td><td>" +
	object.make +"  </td><td>" + object.model +" </td><td>" + object.year +' </td><td><a  target="_blank" href="https://www.jdpower.com/Cars/'+object.year+'/'+object.make+'/'+object.model+'">'+object.year+''+object.make+''+object.model+'</a></td></tr>';
}
}

function RecentSavedData()
{
	var listOfData = localStorage.getItem("listOfData");
if(listOfData != "" && listOfData !==null)
{
	listOfData = JSON.parse(listOfData);
	
}
else{
	listOfData = [];
	var data= document.getElementById("data");
	
}
	
}