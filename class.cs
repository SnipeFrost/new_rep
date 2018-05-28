class Registration_data { // містить реєстраційні дані нового користувача 
  constructor() {
    this.name = ""; this.1ast_name = ; this.photo = ; this.emai1 = "";
    this.password_hash = "";
                }
}

class Login_data { // міСТИть дані для входу користувача до системи
  constructor() {
    this.email =""; this.password_hash = "";
                }
}
class Review_data { // інформація про відгук
  constructor() {
    this.page_id = 0; this.rating = e; this.text = "";
                }
}
class Page  // сторінка, якій відповідає відгук
   constructor() {
    this.id = е;
    this.ur1 = ""; this.tit1e = ""; this.items = []; // містить екземпляри Item
                 }
}
class Item  // Рубрика на сторінки, для якої можна додати відгук
constructor(){
this.id = е; this.page_id = 0; this.num = 0; this.name = ;}
}
