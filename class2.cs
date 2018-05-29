class Registration_screen {

constructor() {
this.request = null;
this.registration_data = new Registration_data();
}

register() {
start_animation();
this.request = new XMLHttpRequest();
request.addEventListener("load", on_server_response);
request.open("POST”, "http://www.examgle.org/aEi/register");
request.setRequestHeader("Content-Type", "application/json");
request.send(JSON.stringify(this.registration_data));
}

on_server_response(data) {
stop_animation();
console.log(this.responseText);
if(this.status == 200)
{

a1ert("Поздравляю вы зарегестрированы!");
location.href = "login.htm1";

}
